// Файл: ShiftForm.Designer.cs

namespace Laba8Enj
{
    partial class ShiftForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelShiftDate;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerShiftDate;
        private System.Windows.Forms.DateTimePicker timePickerStartTime;
        private System.Windows.Forms.DateTimePicker timePickerEndTime;
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
            this.labelShiftDate = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.dateTimePickerShiftDate = new System.Windows.Forms.DateTimePicker();
            this.timePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.timePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelShiftDate
            //
            this.labelShiftDate.AutoSize = true;
            this.labelShiftDate.Location = new System.Drawing.Point(13, 13);
            this.labelShiftDate.Name = "labelShiftDate";
            this.labelShiftDate.Size = new System.Drawing.Size(72, 13);
            this.labelShiftDate.TabIndex = 0;
            this.labelShiftDate.Text = "Дата смены";
            //
            // labelStartTime
            //
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(13, 40);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(87, 13);
            this.labelStartTime.TabIndex = 1;
            this.labelStartTime.Text = "Время начала";
            //
            // labelEndTime
            //
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(13, 67);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(93, 13);
            this.labelEndTime.TabIndex = 2;
            this.labelEndTime.Text = "Время окончания";
            //
            // dateTimePickerShiftDate
            //
            this.dateTimePickerShiftDate.Location = new System.Drawing.Point(137, 10);
            this.dateTimePickerShiftDate.Name = "dateTimePickerShiftDate";
            this.dateTimePickerShiftDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShiftDate.TabIndex = 3;
            //
            // timePickerStartTime
            //
            this.timePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStartTime.Location = new System.Drawing.Point(137, 37);
            this.timePickerStartTime.Name = "timePickerStartTime";
            this.timePickerStartTime.Size = new System.Drawing.Size(200, 20);
            this.timePickerStartTime.TabIndex = 4;
            //
            // timePickerEndTime
            //
            this.timePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEndTime.Location = new System.Drawing.Point(137, 64);
            this.timePickerEndTime.Name = "timePickerEndTime";
            this.timePickerEndTime.Size = new System.Drawing.Size(200, 20);
            this.timePickerEndTime.TabIndex = 5;
            //
            // buttonSave
            //
            this.buttonSave.Location = new System.Drawing.Point(170, 95);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // ShiftForm
            //
            this.ClientSize = new System.Drawing.Size(350, 130);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.timePickerEndTime);
            this.Controls.Add(this.timePickerStartTime);
            this.Controls.Add(this.dateTimePickerShiftDate);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelShiftDate);
            this.Name = "ShiftForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
