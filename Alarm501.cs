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
    public partial class Alarm501 : Form
    {
        public Alarm501()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditAlarm form = new AddEditAlarm();
            form.Show();
        }
    }
}
