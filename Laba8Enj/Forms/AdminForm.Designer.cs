namespace Laba8Enj
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonShifts;
        private System.Windows.Forms.Button buttonReports;

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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonShifts = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewEmployees
            //
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "UserID", HeaderText = "ID", ReadOnly = true },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Username", HeaderText = "Имя пользователя" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Role", HeaderText = "Роль" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Статус" }
            });
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(776, 220);
            this.dataGridViewEmployees.TabIndex = 0;
            //
            // buttonAddEmployee
            //
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 238);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(100, 23);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            //
            // buttonEditEmployee
            //
            this.buttonEditEmployee.Location = new System.Drawing.Point(118, 238);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(100, 23);
            this.buttonEditEmployee.TabIndex = 2;
            this.buttonEditEmployee.Text = "Редактировать сотрудника";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            //
            // buttonDeleteEmployee
            //
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(224, 238);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Удалить сотрудника";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            //
            // buttonOrders
            //
            this.buttonOrders.Location = new System.Drawing.Point(330, 238);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(100, 23);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            //
            // buttonShifts
            //
            this.buttonShifts.Location = new System.Drawing.Point(436, 238);
            this.buttonShifts.Name = "buttonShifts";
            this.buttonShifts.Size = new System.Drawing.Size(100, 23);
            this.buttonShifts.TabIndex = 5;
            this.buttonShifts.Text = "Смены";
            this.buttonShifts.UseVisualStyleBackColor = true;
            this.buttonShifts.Click += new System.EventHandler(this.buttonShifts_Click);
            //
            // buttonReports
            //
            this.buttonReports.Location = new System.Drawing.Point(542, 238);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(100, 23);
            this.buttonReports.TabIndex = 6;
            this.buttonReports.Text = "Отчеты";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            //
            // AdminForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.buttonShifts);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
