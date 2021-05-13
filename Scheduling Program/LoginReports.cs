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
    public partial class LoginReports : Form
    {
        public LoginReports()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string line;

                using (StreamReader sr = new StreamReader("log.text"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        richTextBox1.AppendText(line);
                        richTextBox1.AppendText("\r\n");
                        line = sr.ReadLine();
                    }

                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be read or there is no data.");
            }
        }
    }
}
