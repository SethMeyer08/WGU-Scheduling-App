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
    public partial class CreateCustomer : Form
    {


        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            string userName = SqlUpdater.GetCurrentUserName();

            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(phoneNumberTextBox.Text) ||
                string.IsNullOrEmpty(cityTextBox.Text) ||
                string.IsNullOrEmpty(countryTextBox.Text) ||
                string.IsNullOrEmpty(zipCodeTextBox.Text) ||
                string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                int countryId = SqlUpdater.CreateRecord(timestamp, userName, "country", $"'{countryTextBox.Text}'");
                int cityId = SqlUpdater.CreateRecord(timestamp, userName, "city", $"'{cityTextBox.Text}', '{countryId}'");
                int addressId = SqlUpdater.CreateRecord(timestamp, userName, "address", $"'{addressTextBox.Text}', '', '{cityId}', '{zipCodeTextBox.Text}', '{phoneNumberTextBox.Text}'");
                SqlUpdater.CreateRecord(timestamp, userName, "customer", $"'{ nameTextBox.Text}', '{addressId}', '{(activeRadio.Checked ? 1 : 0)}'");

                MessageBox.Show("Customer created.");
                Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActiveYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
