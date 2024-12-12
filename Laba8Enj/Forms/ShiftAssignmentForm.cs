// Файл: ShiftAssignmentForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class ShiftAssignmentForm : Form
    {
        private DatabaseConnection dbConnection;
        private int shiftId;

        public ShiftAssignmentForm(int shiftId)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.shiftId = shiftId;
            LoadShiftAssignments();
            LoadEmployees();
        }

        private void LoadShiftAssignments()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Users.UserID, Users.Username, Users.Role FROM ShiftAssignments JOIN Users ON ShiftAssignments.UserID = Users.UserID WHERE ShiftAssignments.ShiftID = @ShiftID", conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dataGridViewShiftAssignments.Rows.Clear();
                        while (reader.Read())
                        {
                            dataGridViewShiftAssignments.Rows.Add(reader["UserID"], reader["Username"], reader["Role"]);
                        }
                    }
                }
            }
        }

        private void buttonAddAssignment_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedItem != null && comboBoxEmployees.SelectedValue != null)
            {
                int employeeId = (int)comboBoxEmployees.SelectedValue;
                using (var conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO ShiftAssignments (ShiftID, UserID) VALUES (@ShiftID, @UserID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                        cmd.Parameters.AddWithValue("@UserID", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadShiftAssignments(); // Обновляем список назначений после добавления
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для назначения.");
            }
        }

        private void buttonRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (dataGridViewShiftAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewShiftAssignments.SelectedRows[0];
                if (selectedRow.Cells["UserID"].Value != null)
                {
                    int assignmentId = (int)selectedRow.Cells["UserID"].Value;
                    using (var conn = dbConnection.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand("DELETE FROM ShiftAssignments WHERE ShiftID = @ShiftID AND UserID = @UserID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ShiftID", shiftId);
                            cmd.Parameters.AddWithValue("@UserID", assignmentId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadShiftAssignments(); // Обновляем список назначений после удаления
                }
                else
                {
                    MessageBox.Show("Выбранная строка не содержит данных.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите назначение для удаления.");
            }
        }

        private void ShiftAssignmentForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT UserID, Username FROM Users WHERE Role IN ('Официант', 'Повар')", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxEmployees.Items.Add(new { ID = reader["UserID"], Name = reader["Username"] });
                    }
                }
            }
            comboBoxEmployees.DisplayMember = "Name";
            comboBoxEmployees.ValueMember = "ID";
        }
    }
}
