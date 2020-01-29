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
        private BindingList<string> alarms = new BindingList<string>();
        
        public Alarm501()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditAlarm form = new AddEditAlarm();
            form.ShowDialog();
            StatusText.Text = "";

            if (form.DialogResult == DialogResult.OK)
            {
                alarms.Add(form.on);
                AlarmList.DataSource = alarms;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditAlarm editForm = new AddEditAlarm();
            editForm.ShowDialog();
        }

        private void AlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlarmList != null)
            {
                EditButton.Enabled = true;
            }
            if (AlarmList.Items.Count >= 10)
            {
                AddButton.Enabled = false;
            }
        }
    }
}
