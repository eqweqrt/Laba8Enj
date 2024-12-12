// Файл: TableAssignmentForm.Designer.cs

namespace Laba8Enj
{
    partial class TableAssignmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTableAssignments;
        private System.Windows.Forms.ComboBox comboBoxWaiters;
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
            this.dataGridViewTableAssignments = new System.Windows.Forms.DataGridView();
            this.comboBoxWaiters = new System.Windows.Forms.ComboBox();
            this.buttonAddAssignment = new System.Windows.Forms.Button();
            this.buttonRemoveAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableAssignments)).BeginInit();
            this.SuspendLayout();
            //
            // dataGridViewTableAssignments
            //
            this.dataGridViewTableAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "UserID", HeaderText = "ID официанта" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Username", HeaderText = "Имя официанта" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Role", HeaderText = "Роль" }
            });
            this.dataGridViewTableAssignments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTableAssignments.Name = "dataGridViewTableAssignments";
            this.dataGridViewTableAssignments.Size = new System.Drawing.Size(776, 220);
            this.dataGridViewTableAssignments.TabIndex = 0;
            //
            // comboBoxWaiters
            //
            this.comboBoxWaiters.FormattingEnabled = true;
            this.comboBoxWaiters.Location = new System.Drawing.Point(12, 238);
            this.comboBoxWaiters.Name = "comboBoxWaiters";
            this.comboBoxWaiters.Size = new System.Drawing.Size(200, 21);
            this.comboBoxWaiters.TabIndex = 1;
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
            // TableAssignmentForm
            //
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveAssignment);
            this.Controls.Add(this.buttonAddAssignment);
            this.Controls.Add(this.comboBoxWaiters);
            this.Controls.Add(this.dataGridViewTableAssignments);
            this.Name = "TableAssignmentForm";
            this.Load += new System.EventHandler(this.TableAssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableAssignments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
