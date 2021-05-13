using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969___Seth_Meyer___Scheduling_Software
{
    public partial class DeleteAppointment : Form
    {
        public MainForm mainFormObject;
        public DeleteAppointment()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = appointmentIDTextBox.Text;
            appointmentDetails = SqlUpdater.GetAppointmentDetails(appointmentId);
            pullCustomerID.Text = appointmentDetails["customerId"];
            pullTypeLabel.Text = appointmentDetails["type"];
            pullStartLabel.Text = appointmentDetails["start"];
            pullEndLabel.Text = appointmentDetails["end"];

        }

        private void button1_Click(object sender, EventArgs e) // Cancel Button
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // Delete Button
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you wish to delete this Appointment?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.Yes)
            {
                if (DeleteApp())
                {
                    MessageBox.Show($"Appointment: {appointmentDetails["type"]} was deleted.");
                } else
                {
                    MessageBox.Show($"Appointment: {appointmentDetails["type"]} was not deleted.");
                }
            }

            Close();
        }

        public static Dictionary<string, string> appointmentDetails = new Dictionary<string, string>();

        public static bool DeleteApp()
        {
            MySqlConnection conn = new MySqlConnection(SqlUpdater.conString);
            conn.Open();

            string recDelete = $"DELETE FROM appointment" + $" WHERE appointmentId = '{appointmentDetails["appointmentId"]}'";

            MySqlCommand cmd = new MySqlCommand(recDelete, conn);
            int appointmentDeleted = cmd.ExecuteNonQuery();
            conn.Close();

            if (appointmentDeleted != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
