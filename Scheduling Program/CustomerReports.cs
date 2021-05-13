using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C969___Seth_Meyer___Scheduling_Software
{
    public partial class CustomerReports : Form
    {
        public CustomerReports()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "_log.txt";

            string[] readText = File.ReadAllLines(path);
            IList<String> dataStrings = new List<String>();

            foreach (string s in readText)
            {
                dataStrings.Add(s);
            }

            if (readText.Length == 0)
            {
                dataStrings.Add("No Login information is present.");
            }

            dataGridView1.DataSource = dataStrings.Select(x => new { Value = x }).ToList();
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
