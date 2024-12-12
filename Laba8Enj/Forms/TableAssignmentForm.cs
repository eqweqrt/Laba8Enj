// Файл: TableAssignmentForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class TableAssignmentForm : Form
    {
        private DatabaseConnection dbConnection;
        private int tableNumber;

        public TableAssignmentForm(int tableNumber)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.tableNumber = tableNumber;
            LoadTableAssignments();
            LoadWaiters();
        }

        private void LoadTableAssignments()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Users.UserID, Users.Username, Users.Role FROM TableAssignments JOIN Users ON TableAssignments.UserID = Users.UserID WHERE TableAssignments.TableNumber = @TableNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dataGridViewTableAssignments.Rows.Clear();
                        while (reader.Read())
                        {
                            dataGridViewTableAssignments.Rows.Add(reader["UserID"], reader["Username"], reader["Role"]);
                        }
                    }
                }
            }
        }

        private void buttonAddAssignment_Click(object sender, EventArgs e)
        {
            if (comboBoxWaiters.SelectedItem != null && comboBoxWaiters.SelectedValue != null)
            {
                int waiterId = (int)comboBoxWaiters.SelectedValue;
                using (var conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO TableAssignments (TableNumber, UserID) VALUES (@TableNumber, @UserID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                        cmd.Parameters.AddWithValue("@UserID", waiterId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadTableAssignments(); // Обновляем список назначений после добавления
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите официанта для назначения.");
            }
        }

        private void buttonRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTableAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewTableAssignments.SelectedRows[0];
                if (selectedRow.Cells["UserID"].Value != null)
                {
                    int assignmentId = (int)selectedRow.Cells["UserID"].Value;
                    using (var conn = dbConnection.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand("DELETE FROM TableAssignments WHERE TableNumber = @TableNumber AND UserID = @UserID", conn))
                        {
                            cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                            cmd.Parameters.AddWithValue("@UserID", assignmentId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadTableAssignments(); // Обновляем список назначений после удаления
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

        private void TableAssignmentForm_Load(object sender, EventArgs e)
        {
            LoadWaiters();
        }

        private void LoadWaiters()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'Официант'", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxWaiters.Items.Add(new { ID = reader["UserID"], Name = reader["Username"] });
                    }
                }
            }
            comboBoxWaiters.DisplayMember = "Name";
            comboBoxWaiters.ValueMember = "ID";
        }
    }
}
