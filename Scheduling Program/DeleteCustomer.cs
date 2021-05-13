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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> customerDetails = new Dictionary<string, string>();

        public bool DeleteCust()
        {
            MySqlConnection conn = new MySqlConnection(SqlUpdater.conString);
            conn.Open();

            string recUpdate = $"DELETE FROM customer" + $" WHERE customerName = '{customerDetails["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, conn);
            int customerUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"DELETE FROM address" + $" WHERE address = '{customerDetails["address"]}'";
            cmd = new MySqlCommand(recUpdate, conn);
            int addressUpdated = cmd.ExecuteNonQuery();

            conn.Close();

            if (customerUpdated != 0 && addressUpdated != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int customerId = SqlUpdater.FindCustomer(custSearchBox.Text);
            if (customerId != 0)
            {
                customerDetails = SqlUpdater.GetCustomerDetails(customerId);
                pullNameLabel.Text = customerDetails["customerName"];
                pullPhoneLabel.Text = customerDetails["phone"];
                pullAddressLabel.Text = customerDetails["address"];
                pullCityLabel.Text = customerDetails["city"];
                pullZipCodeLabel.Text = customerDetails["zip"];
                pullCountryLabel.Text = customerDetails["country"];
            } else
            {
                MessageBox.Show("Unable to find customer.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you wish to delete this Customer?", "Confirm Delete?", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if (DeleteCust())
                {
                    MessageBox.Show($"Customer: {customerDetails["customerName"]} was deleted.");
                } else
                {
                    MessageBox.Show($"Customer: {customerDetails["customerName"]} was not deleted.");
                }
            }
        }
    }
}
