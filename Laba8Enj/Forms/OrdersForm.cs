// Файл: OrderForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class OrderForm : Form
    {
        private DatabaseConnection dbConnection;
        private int orderId;

        public OrderForm(int orderId = -1)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.orderId = orderId;

            if (orderId != -1)
            {
                LoadOrderData();
            }
        }

        private void LoadOrderData()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM Orders WHERE OrderID = @OrderID", conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxTableNumber.Text = reader["TableNumber"].ToString();
                            textBoxCustomerCount.Text = reader["CustomerCount"].ToString();
                            comboBoxOrderStatus.SelectedItem = reader["OrderStatus"].ToString();
                            textBoxTotalAmount.Text = reader["TotalAmount"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (orderId == -1)
            {
                AddOrder();
            }
            else
            {
                EditOrder();
            }
            this.Close();
        }

        private void AddOrder()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Orders (TableNumber, CustomerCount, OrderStatus, TotalAmount) VALUES (@TableNumber, @CustomerCount, @OrderStatus, @TotalAmount)", conn))
                {
                    cmd.Parameters.AddWithValue("@TableNumber", textBoxTableNumber.Text);
                    cmd.Parameters.AddWithValue("@CustomerCount", textBoxCustomerCount.Text);
                    cmd.Parameters.AddWithValue("@OrderStatus", comboBoxOrderStatus.SelectedItem);
                    cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(textBoxTotalAmount.Text));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void EditOrder()
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE Orders SET TableNumber = @TableNumber, CustomerCount = @CustomerCount, OrderStatus = @OrderStatus, TotalAmount = @TotalAmount WHERE OrderID = @OrderID", conn))
                {
                    cmd.Parameters.AddWithValue("@TableNumber", textBoxTableNumber.Text);
                    cmd.Parameters.AddWithValue("@CustomerCount", textBoxCustomerCount.Text);
                    cmd.Parameters.AddWithValue("@OrderStatus", comboBoxOrderStatus.SelectedItem);
                    cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(textBoxTotalAmount.Text));
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
