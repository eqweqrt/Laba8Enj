// Файл: ReportForm.Designer.cs

namespace Laba8Enj
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.TextBox textBoxReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // comboBoxReportType
            //
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] { "Отчет о заказах", "Отчет о выручке" });
            this.comboBoxReportType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxReportType.TabIndex = 0;
            //
            // buttonGenerateReport
            //
            this.buttonGenerateReport.Location = new System.Drawing.Point(218, 10);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "Сгенерировать";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            //
            // textBoxReport
            //
            this.textBoxReport.Location = new System.Drawing.Point(12, 39);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReport.Size = new System.Drawing.Size(776, 399);
            this.textBoxReport.TabIndex = 2;
            //
            // ReportForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.comboBoxReportType);
            this.Name = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
