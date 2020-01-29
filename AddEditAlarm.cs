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
            DateTime currentTime = DateTime.Now;
            DateTime userTime = TimePicker.Value;

            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
