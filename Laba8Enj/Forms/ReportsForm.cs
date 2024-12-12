// Файл: ReportForm.cs

using System;
using System.Windows.Forms;
using Npgsql;

namespace Laba8Enj
{
    public partial class ReportForm : Form
    {
        private DatabaseConnection dbConnection;

        public ReportForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Здесь можно добавить логику для загрузки данных по умолчанию, если необходимо
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            // Логика для генерации отчета
            string reportType = comboBoxReportType.SelectedItem.ToString();
            string reportData = GetReportData(reportType);

            // Отображение отчета в текстовом поле или сохранение в файл
            textBoxReport.Text = reportData;
        }

        private string GetReportData(string reportType)
        {
            string reportData = "";
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "";

                switch (reportType)
                {
                    case "Отчет о заказах":
                        query = "SELECT * FROM Orders";
                        break;
                    case "Отчет о выручке":
                        query = "SELECT SUM(TotalAmount) AS TotalRevenue FROM Orders WHERE OrderStatus = 'Оплачен'";
                        break;
                        // Добавьте другие типы отчетов по мере необходимости
                }

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reportType == "Отчет о выручке")
                        {
                            reportData += $"Общая выручка: {reader["TotalRevenue"]}\n";
                        }
                        else
                        {
                            reportData += $"{reader["OrderID"]}, {reader["TableNumber"]}, {reader["CustomerCount"]}, {reader["OrderStatus"]}, {reader["TotalAmount"]}\n";
                        }
                    }
                }
            }
            return reportData;
        }
    }
}
