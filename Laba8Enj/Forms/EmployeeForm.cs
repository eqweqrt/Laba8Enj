// Файл: EmployeeForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class EmployeeForm : Form
    {
        private DatabaseConnection dbConnection;
        private int employeeId;

        public EmployeeForm(int employeeId = -1)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.employeeId = employeeId;

            if (employeeId != -1)
            {
                LoadEmployeeData();
            }
        }

        private void LoadEmployeeData()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Users WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", employeeId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxUsername.Text = reader["Username"].ToString();
                            textBoxPassword.Text = reader["Password"].ToString();
                            comboBoxRole.SelectedItem = reader["Role"].ToString();
                            comboBoxStatus.SelectedItem = reader["Status"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (employeeId == -1)
            {
                AddEmployee();
            }
            else
            {
                EditEmployee();
            }
            this.Close();
        }

        private void AddEmployee()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Users (Username, Password, Role, Status) VALUES (@Username, @Password, @Role, @Status)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", comboBoxRole.SelectedItem);
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void EditEmployee()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE Users SET Username = @Username, Password = @Password, Role = @Role, Status = @Status WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", comboBoxRole.SelectedItem);
                    cmd.Parameters.AddWithValue("@Status", comboBoxStatus.SelectedItem);
                    cmd.Parameters.AddWithValue("@UserID", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
