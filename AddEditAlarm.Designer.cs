namespace AdelaRahman.CIS501.AlarmClock
{
    partial class AddEditAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.OnButton = new System.Windows.Forms.RadioButton();
            this.SetButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(12, 27);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(289, 20);
            this.TimePicker.TabIndex = 0;
            // 
            // OnButton
            // 
            this.OnButton.AutoSize = true;
            this.OnButton.Location = new System.Drawing.Point(320, 29);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(39, 17);
            this.OnButton.TabIndex = 1;
            this.OnButton.TabStop = true;
            this.OnButton.Text = "On";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.CheckedChanged += new System.EventHandler(this.OnButton_CheckedChanged);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(259, 75);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(95, 53);
            this.SetButton.TabIndex = 2;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 75);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 53);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 160);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.TimePicker);
            this.Name = "AddEditAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.RadioButton OnButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button CancelButton;
    }
}