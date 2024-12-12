// Файл: ShiftForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class ShiftForm : Form
    {
        private DatabaseConnection dbConnection;
        private int shiftId;

        public ShiftForm(int shiftId = -1)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.shiftId = shiftId;

            if (shiftId != -1)
            {
                LoadShiftData();
            }
        }

        private void LoadShiftData()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Shifts WHERE ShiftID = @ShiftID", conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dateTimePickerShiftDate.Value = (DateTime)reader["ShiftDate"];
                            timePickerStartTime.Value = DateTime.Parse(reader["StartTime"].ToString());
                            timePickerEndTime.Value = DateTime.Parse(reader["EndTime"].ToString());
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (shiftId == -1)
            {
                AddShift();
            }
            else
            {
                EditShift();
            }
            this.Close();
        }

        private void AddShift()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Shifts (ShiftDate, StartTime, EndTime) VALUES (@ShiftDate, @StartTime, @EndTime)", conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftDate", dateTimePickerShiftDate.Value.Date);
                    cmd.Parameters.AddWithValue("@StartTime", timePickerStartTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@EndTime", timePickerEndTime.Value.TimeOfDay);
                    cmd.ExecuteNonQuery();
                }
            }

            // После добавления смены, откроем форму для назначения сотрудников на эту смену
            int newShiftId = GetLastInsertedShiftId();
            using (var form = new ShiftAssignmentForm(newShiftId))
            {
                form.ShowDialog();
            }
        }

        private int GetLastInsertedShiftId()
        {
            int lastInsertedShiftId = -1;
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT ShiftID FROM Shifts ORDER BY ShiftID DESC LIMIT 1", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lastInsertedShiftId = (int)reader["ShiftID"];
                    }
                }
            }
            return lastInsertedShiftId;
        }

        private void EditShift()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE Shifts SET ShiftDate = @ShiftDate, StartTime = @StartTime, EndTime = @EndTime WHERE ShiftID = @ShiftID", conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftDate", dateTimePickerShiftDate.Value.Date);
                    cmd.Parameters.AddWithValue("@StartTime", timePickerStartTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@EndTime", timePickerEndTime.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
