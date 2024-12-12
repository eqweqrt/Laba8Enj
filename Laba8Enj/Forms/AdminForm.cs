using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class AdminForm : Form
    {
        private DatabaseConnection dbConnection;

        public AdminForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Users", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dataGridViewEmployees.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewEmployees.Rows.Add(reader["UserID"], reader["Username"], reader["Role"], reader["Status"]);
                    }
                }
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new EmployeeForm())
            {
                form.ShowDialog();
                LoadEmployees(); // Обновляем список сотрудников после добавления
            }
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells["UserID"].Value;
                using (var form = new EmployeeForm(employeeId))
                {
                    form.ShowDialog();
                    LoadEmployees(); // Обновляем список сотрудников после редактирования
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования.");
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells["UserID"].Value;
                using (var conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadEmployees(); // Обновляем список сотрудников после удаления
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.");
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            using (var form = new OrderForm())
            {
                form.ShowDialog();
            }
        }

        private void buttonShifts_Click(object sender, EventArgs e)
        {
            using (var form = new ShiftForm())
            {
                form.ShowDialog();
            }
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            using (var form = new ReportForm())
            {
                form.ShowDialog();
            }
        }
    }
}
