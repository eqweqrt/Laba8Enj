// Файл: ShiftAssignmentForm.Designer.cs

namespace Laba8Enj
{
    partial class ShiftAssignmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewShiftAssignments;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Button buttonAddAssignment;
        private System.Windows.Forms.Button buttonRemoveAssignment;

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
            this.dataGridViewShiftAssignments = new System.Windows.Forms.DataGridView();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.buttonAddAssignment = new System.Windows.Forms.Button();
            this.buttonRemoveAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShiftAssignments)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewShiftAssignments
            //
            this.dataGridViewShiftAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShiftAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "UserID", HeaderText = "ID сотрудника" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Username", HeaderText = "Имя сотрудника" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Role", HeaderText = "Роль" }
            });
            this.dataGridViewShiftAssignments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShiftAssignments.Name = "dataGridViewShiftAssignments";
            this.dataGridViewShiftAssignments.Size = new System.Drawing.Size(776, 220);
            this.dataGridViewShiftAssignments.TabIndex = 0;
            //
            // comboBoxEmployees
            //
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(12, 238);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEmployees.TabIndex = 1;
            //
            // buttonAddAssignment
            //
            this.buttonAddAssignment.Location = new System.Drawing.Point(218, 236);
            this.buttonAddAssignment.Name = "buttonAddAssignment";
            this.buttonAddAssignment.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAssignment.TabIndex = 2;
            this.buttonAddAssignment.Text = "Назначить";
            this.buttonAddAssignment.UseVisualStyleBackColor = true;
            this.buttonAddAssignment.Click += new System.EventHandler(this.buttonAddAssignment_Click);
            //
            // buttonRemoveAssignment
            //
            this.buttonRemoveAssignment.Location = new System.Drawing.Point(300, 236);
            this.buttonRemoveAssignment.Name = "buttonRemoveAssignment";
            this.buttonRemoveAssignment.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAssignment.TabIndex = 3;
            this.buttonRemoveAssignment.Text = "Удалить";
            this.buttonRemoveAssignment.UseVisualStyleBackColor = true;
            this.buttonRemoveAssignment.Click += new System.EventHandler(this.buttonRemoveAssignment_Click);
            //
            // ShiftAssignmentForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveAssignment);
            this.Controls.Add(this.buttonAddAssignment);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.dataGridViewShiftAssignments);
            this.Name = "ShiftAssignmentForm";
            this.Load += new System.EventHandler(this.ShiftAssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShiftAssignments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
