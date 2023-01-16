using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelethonSystemWin
{
    public partial class WelcomeForm : Form
    {
        int counter = 0;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "ETS")
            {
                counter++;  
                MessageBox.Show("Wrong username");
                txtUsername.Clear();
                txtUsername.Focus();
            }
            else
            {
                if(txtPassword.Text != "admin")
                {
                    counter++;
                    MessageBox.Show("Wrong password");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
            }
            if (counter == 3)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
