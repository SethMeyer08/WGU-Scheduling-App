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
    public partial class MainForm : Form
    {
        public Login loginForm;

        public static string conString = SqlUpdater.GetconString();
        public MainForm()
        {
            InitializeComponent();
            MainForm_Load(weeklyRadio.Checked = true);
            ReminderCheck(dataGridView1);
        }

        public static string SetApptId = "";

        public static string SetCustName = "";

        public void MainForm_Load(bool week)
        {
            DateTime filter = week ? CalcDateFilter("week") : CalcDateFilter("month");
            DataTable dtRecord = SqlUpdater.FirstCal(SqlUpdater.DateSQLFormat(filter), week);
            dataGridView1.DataSource = dtRecord;
        }

        public static DateTime CalcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            } else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }

        public static void ReminderCheck(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[4].Value.ToString()).ToUniversalTime();
                TimeSpan nowUntilStartOfApp = now - start;
                if (nowUntilStartOfApp.TotalMinutes >= -15 && nowUntilStartOfApp.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: you have a meeting within 15 minutes. ");
                }
            }


        }

        private void createCustButton_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.Show();
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.Show();
        }

        private void createApptButton_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment
            {
                mainFormObject = this
            };
            addAppointment.Show();
        }

        private void updateApptButton_Click(object sender, EventArgs e)
        {
            UpdateAppointment updateAppointment = new UpdateAppointment
            {
                mainFormObject = this
            };
            updateAppointment.Show();
        }

        private void deleteApptButton_Click(object sender, EventArgs e)
        {
            DeleteAppointment deleteAppointment = new DeleteAppointment
            {
                mainFormObject = this
            };
            deleteAppointment.Show();
        }

        private void weeklyRadio_CheckedChanged(object sender, EventArgs e)
        {
            MainForm_Load(weeklyRadio.Checked);
        }

        public void UpdateCalendar()
        {
            MainForm_Load(weeklyRadio.Checked);
        }
        private void monthlyRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apptMonthButton_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
        }

        private void consultantSchedButton_Click(object sender, EventArgs e)
        {
            Schedules schedules = new Schedules();
            schedules.Show();
        }

        private void loginReportButton_Click(object sender, EventArgs e)
        {
            LoginReports loginreports = new LoginReports();
            loginreports.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
