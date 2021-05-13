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
    public partial class Schedules : Form
    {
        public static List<KeyValuePair<string, object>> userList;
        public Schedules()
        {
            InitializeComponent();
            FillConsole();
        }

        public void SetUserList(List<KeyValuePair<string, object>> list)
        {
            userList = list;
        }

        public static List<KeyValuePair<string, object>> GetUserList()
        {
            return userList;
        }

        public void FillConsole()
        {
            MySqlConnection conn = new MySqlConnection(SqlUpdater.conString);

            try
            {
                string query = "select userId, userName as 'Display' from user;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                consultantComboBox.DisplayMember = "Display";
                consultantComboBox.ValueMember = "userId";
                consultantComboBox.DataSource = ds.Tables["User"];
            } catch (Exception ex)
            {
                Console.WriteLine("Error occurred! " + ex);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = consultantComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(consultantComboBox.SelectedValue);

            DataTable dtRecord = SqlUpdater.Schedule(id.ToString());
            dataGridView1.DataSource = dtRecord;
        }
    }
}
