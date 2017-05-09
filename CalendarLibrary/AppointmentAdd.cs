using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

namespace AC.ExtendedRenderer.Toolkit.CalendarLibrary
{
    public partial class AppointmentAdd : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private Calendar _calendar;
        public AppointmentAdd(ref Calendar Calendar)
        {
            InitializeComponent();
            _calendar = Calendar;

            datePicker.Value = DateTime.Now;
            startHour.Value = DateTime.Now.Hour;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
            DateTime startTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, (int)this.startHour.Value, Int32.Parse(this.startMinute.Text), 0);
            DateTime endTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, (int)this.endHour.Value, Int32.Parse(this.endMinute.Text), 0);

            if (endTime.CompareTo(startTime) <= 0)
            {
                MessageBox.Show("End time is either same as or before the start time. Please check the times");
                return;
            }

            if (this.descriptionTextBox.Text == null || this.descriptionTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter some description of this item");
                return;
            }

            _calendar.CalendarItems.Add(new CalendarItem(startTime, endTime, this.descriptionTextBox.Text, this.tentativeCheckBox.Checked, this.txtKey.Text, this.txtColor.Text));
            _calendar.InitializeDisplay();
            }
            catch (Exception ex)
            {
            	Trace.WriteLine(ex.ToString());
            }
        }

        private void startHour_ValueChanged(object sender, EventArgs e)
        {
            endHour.Value = (startHour.Value == 23) ? 23 : startHour.Value + 1;
        }

        private void startMinute_TextChanged(object sender, EventArgs e)
        {
            if (startMinute.Text == "00")
                endMinute.Text = "30";
            else
                endMinute.Text = "00";
        }


    }
}