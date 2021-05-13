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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> cForm = new Dictionary<string, string>();

        public bool UpdateCust(Dictionary<string, string> updatedForm)
        {
            MySqlConnection conn = new MySqlConnection(SqlUpdater.conString);
            conn.Open();

            /*string recUpdate = $"UPDATE customer" + $" SET customerName = '{updatedForm["customerName"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE customerName = '{cForm["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, conn);
            int customerUpdated = cmd.ExecuteNonQuery();*/

            string recUpdate = $"UPDATE customer" +
                $" SET customerName = '{updatedForm["customerName"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE customerName = '{cForm["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, conn);
            int customerUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE address" +
                $" SET address = '{updatedForm["address"]}', postalCode = '{updatedForm["zip"]}', phone = '{updatedForm["phone"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE address = '{cForm["address"]}'";
            cmd = new MySqlCommand(recUpdate, conn);
            int addressUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE city" + $" SET city = '{updatedForm["city"]}, lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE city = '{cForm["city"]}'";
            cmd = new MySqlCommand(recUpdate, conn);
            int cityUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE country" + $" SET country = '{updatedForm["country"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE country = '{cForm["country"]}'";
            cmd = new MySqlCommand(recUpdate, conn);
            int countryUpdated = cmd.ExecuteNonQuery();

            conn.Close();

            if (customerUpdated != 0 && addressUpdated != 0 && cityUpdated != 0 && countryUpdated != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                int customerId = SqlUpdater.FindCustomer(custSearchBox.Text);
                if (customerId != 0)
                {
                    cForm = SqlUpdater.GetCustomerDetails(customerId);
                    nameTextBox.Text = cForm["customerName"];
                    phoneTextBox.Text = cForm["phone"];
                    cityTextBox.Text = cForm["city"];
                    addressTextBox.Text = cForm["address"];
                    zipCodeTextBox.Text = cForm["zip"];
                    countryTextBox.Text = cForm["country"];
                } else
                {
                    MessageBox.Show("Unable to find this customer.");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> updatedForm = new Dictionary<string, string>
            {
                {"customerName", nameTextBox.Text },
                {"phone", phoneTextBox.Text },
                {"address", addressTextBox.Text },
                {"city", cityTextBox.Text },
                {"country", countryTextBox.Text },
                {"zip", zipCodeTextBox.Text }
            };

            if (UpdateCust(updatedForm))
            {
                MessageBox.Show("Update was successful!");
            } else
            {
                MessageBox.Show("Update failed!");
            }
        }
    }
}
