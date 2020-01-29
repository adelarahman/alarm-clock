using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdelaRahman.CIS501.AlarmClock
{
    public partial class AddEditAlarm : Form
    {
        System.Timers.Timer timer;
        public DateTime userTimePicked;
        public string isOn;
        public string on;
        public string text;

        public AddEditAlarm()
        {
            InitializeComponent();
        }

        private void OnButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OnButton.Checked == true)
            {
                timer = new System.Timers.Timer();
                timer.Interval = 1000;
                timer.Elapsed += timer_Elapsed;
            }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            userTimePicked = TimePicker.Value;
            DateTime currentTime = DateTime.Now;
            if (userTimePicked.Hour == currentTime.Hour && userTimePicked.Minute == currentTime.Minute && userTimePicked.Second == currentTime.Second)
            {
                timer.Stop();
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (OnButton.Checked)
            {
                timer.Start();
                isOn = "ON";
            }
            else
            {
                isOn = "OFF";
            }
            on = (TimePicker.Value.ToShortTimeString() + "           " + isOn);
            this.DialogResult = DialogResult.OK;
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (OnButton.Checked)
            {
                timer.Dispose();
            }
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
