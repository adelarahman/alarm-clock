namespace AdelaRahman.CIS501.AlarmClock
{
    partial class Alarm501
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AlarmList = new System.Windows.Forms.ListBox();
            this.SnoozeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AddButton.Location = new System.Drawing.Point(233, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 51);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 14);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(111, 51);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AlarmList
            // 
            this.AlarmList.FormattingEnabled = true;
            this.AlarmList.Location = new System.Drawing.Point(12, 82);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(332, 290);
            this.AlarmList.TabIndex = 2;
            // 
            // SnoozeButton
            // 
            this.SnoozeButton.Location = new System.Drawing.Point(233, 393);
            this.SnoozeButton.Name = "SnoozeButton";
            this.SnoozeButton.Size = new System.Drawing.Size(111, 64);
            this.SnoozeButton.TabIndex = 3;
            this.SnoozeButton.Text = "Snooze";
            this.SnoozeButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 393);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(111, 64);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 479);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SnoozeButton);
            this.Controls.Add(this.AlarmList);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox AlarmList;
        private System.Windows.Forms.Button SnoozeButton;
        private System.Windows.Forms.Button StopButton;
    }
}

