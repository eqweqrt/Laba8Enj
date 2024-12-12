// Файл: OrderForm.Designer.cs

namespace Laba8Enj
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.Label labelCustomerCount;
        private System.Windows.Forms.Label labelOrderStatus;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox textBoxTableNumber;
        private System.Windows.Forms.TextBox textBoxCustomerCount;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Button buttonSave;

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
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.labelCustomerCount = new System.Windows.Forms.Label();
            this.labelOrderStatus = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.textBoxTableNumber = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCount = new System.Windows.Forms.TextBox();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelTableNumber
            //
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Location = new System.Drawing.Point(13, 13);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(81, 13);
            this.labelTableNumber.TabIndex = 0;
            this.labelTableNumber.Text = "Номер стола";
            //
            // labelCustomerCount
            //
            this.labelCustomerCount.AutoSize = true;
            this.labelCustomerCount.Location = new System.Drawing.Point(13, 40);
            this.labelCustomerCount.Name = "labelCustomerCount";
            this.labelCustomerCount.Size = new System.Drawing.Size(111, 13);
            this.labelCustomerCount.TabIndex = 1;
            this.labelCustomerCount.Text = "Количество клиентов";
            //
            // labelOrderStatus
            //
            this.labelOrderStatus.AutoSize = true;
            this.labelOrderStatus.Location = new System.Drawing.Point(13, 67);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(84, 13);
            this.labelOrderStatus.TabIndex = 2;
            this.labelOrderStatus.Text = "Статус заказа";
            //
            // labelTotalAmount
            //
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(13, 94);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(87, 13);
            this.labelTotalAmount.TabIndex = 3;
            this.labelTotalAmount.Text = "Общая сумма";
            //
            // textBoxTableNumber
            //
            this.textBoxTableNumber.Location = new System.Drawing.Point(137, 10);
            this.textBoxTableNumber.Name = "textBoxTableNumber";
            this.textBoxTableNumber.Size = new System.Drawing.Size(200, 20);
            this.textBoxTableNumber.TabIndex = 4;
            //
            // textBoxCustomerCount
            //
            this.textBoxCustomerCount.Location = new System.Drawing.Point(137, 37);
            this.textBoxCustomerCount.Name = "textBoxCustomerCount";
            this.textBoxCustomerCount.Size = new System.Drawing.Size(200, 20);
            this.textBoxCustomerCount.TabIndex = 5;
            //
            // comboBoxOrderStatus
            //
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Items.AddRange(new object[] { "Принят", "Готовится", "Готов", "Оплачен" });
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(137, 64);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxOrderStatus.TabIndex = 6;
            //
            // textBoxTotalAmount
            //
            this.textBoxTotalAmount.Location = new System.Drawing.Point(137, 91);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.textBoxTotalAmount.TabIndex = 7;
            //
            // buttonSave
            //
            this.buttonSave.Location = new System.Drawing.Point(170, 122);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // OrderForm
            //
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.comboBoxOrderStatus);
            this.Controls.Add(this.textBoxCustomerCount);
            this.Controls.Add(this.textBoxTableNumber);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelOrderStatus);
            this.Controls.Add(this.labelCustomerCount);
            this.Controls.Add(this.labelTableNumber);
            this.Name = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
