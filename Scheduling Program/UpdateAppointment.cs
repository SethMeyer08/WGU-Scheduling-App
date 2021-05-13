using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969___Seth_Meyer___Scheduling_Software
{
    public partial class UpdateAppointment : Form
    {


        public UpdateAppointment()
        {
            InitializeComponent();
        }

        public MainForm mainFormObject;
        
        public static Dictionary<string, string> form = new Dictionary<string, string>();
        private void searchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = searchTextBox.Text;
            form = SqlUpdater.GetAppointmentDetails(appointmentId);
            customerIDTextBox.Text = form["customerId"];
            typeTextBox.Text = form["type"];
            startTextBox.Text = SqlUpdater.ConvertToTimezone(form["start"]);
            endTextBox.Text = (SqlUpdater.ConvertToTimezone(form["end"]));
        }

        public static bool AppHasConflict(DateTime startTime, DateTime endTime)
        {
            foreach (var app in SqlUpdater.GetAppointments().Values)
            {
                if (startTime < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < endTime) return true;
            }

            return false;
        }

        public static bool OutsideBusinessHours(DateTime startTime, DateTime endTime)
        {
            startTime = startTime.ToLocalTime();
            endTime = endTime.ToLocalTime();
            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            if (startTime.TimeOfDay > businessStart.TimeOfDay && startTime.TimeOfDay < businessEnd.TimeOfDay &&
                endTime.TimeOfDay > businessStart.TimeOfDay && endTime.TimeOfDay < businessEnd.TimeOfDay) return false;
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            int userId = SqlUpdater.GetCurrentUserID();
            string username = SqlUpdater.GetCurrentUserName();
            int appointmentId = Convert.ToInt32(searchTextBox.Text);
            int customerId = Convert.ToInt32(customerIDTextBox.Text);
            string type = typeTextBox.Text;
            DateTime startTime = DateTime.Parse(startTextBox.Text).ToUniversalTime();
            DateTime endTime = DateTime.Parse(endTextBox.Text).ToUniversalTime();
            string st = DateTime.Parse(startTextBox.Text).ToUniversalTime().ToString("u");
            string et = DateTime.Parse(endTextBox.Text).ToUniversalTime().ToString("u");

            bool pass = Validator();

            if (pass)
            {
                try
                {
                    if (AppHasConflict(startTime, endTime))
                    {
                        throw new AppointmentExceptions();
                    } else
                    {
                        try
                        {
                            if (OutsideBusinessHours(startTime, endTime))
                            {
                                throw new AppointmentExceptions();
                            } else
                            {
                                SqlUpdater.UpdateAppt(customerId, userId, st, et, type, timestamp, username, appointmentId);

                                mainFormObject.UpdateCalendar();
                                MessageBox.Show("Update Successful!");
                                Close();
                            }
                        } catch (AppointmentExceptions ex) { ex.BusinessHours(); }
                    }
                } catch (AppointmentExceptions ex) { ex.ApptOverlap(); }
            }
            else
            {
                MessageBox.Show("Add Appointment Error!");
            }
        }

        private bool Validator()
        {
            if (EmptyCheck() == false)
            {
                MessageBox.Show("Please fill out all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(customerIDTextBox.Text, "[^0-9]+$"))
            {
                ShowError(customerIDLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(typeTextBox.Text, "[^a-zA-Z]+$"))
            {
                ShowError(typeLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(startTextBox.Text, "[^0-9:/]+$"))
            {
                ShowError(startLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(endTextBox.Text, "[^0-9:/]+$"))
            {
                ShowError(endLabel.Text);
                return false;
            }
            return true;
        }

        private void ShowError(string item)
        {
            MessageBox.Show("Please enter valid information for " + item);
        }

        private bool EmptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return false;
                    }
                }

                if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
