using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelethonSystemDLL;

namespace TelethonSystemWin
{
    public partial class MainForm : Form
    {
        ETSManager manager = new ETSManager();
        char type;
        public char getCreditCardType()
        {
            if (radioBtnAmex.Checked == true)
            {
                type = 'A';
            }
            else
            {
                if (radioBtnVISA.Checked == true)
                {
                    type = 'V';
                }
                else
                {
                    if (radioBtnMC.Checked == true)
                    {
                        type = 'M';
                    }
                }
            }
            return type;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the Telethon System Application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Application.Exit();
            }               
        }

        private void btnAddSponsor_Click(object sender, EventArgs e)
        {
            string message = manager.addSponsor(txtSponsorFirstName.Text, txtSponsorLastName.Text, txtSponsorID.Text);
            MessageBox.Show(message);
            txtSponsorFirstName.Clear();
            txtSponsorLastName.Clear();
            txtSponsorID.Clear();
        }

        private void btnAddPrize_Click(object sender, EventArgs e)
        {
            string message = manager.addPrize(txtPrizeID.Text, txtPrizeDescription.Text, txtSponsID.Text, Convert.ToDouble(txtPrizeValue.Text), Convert.ToDouble(txtMinDonationLimit.Text), Convert.ToInt16(txtPrizeQuantity.Text));
            MessageBox.Show(message);
            txtPrizeID.Clear();
            txtPrizeDescription.Clear();
            txtSponsID.Clear();
            txtPrizeValue.Clear();
            txtMinDonationLimit.Clear();
            txtPrizeQuantity.Clear();
        }

        private void btnViewSponsors_Click(object sender, EventArgs e)
        {
            string viewSponsors = manager.listSponsors();
            MessageBox.Show(viewSponsors);
        }

        private void btnViewPrizes_Click(object sender, EventArgs e)
        {
            string viewPrizes = manager.listPrizes();
            MessageBox.Show(viewPrizes);
        }

        private void btnShowPrizes_Click(object sender, EventArgs e)
        {
            string showPrizes = manager.listQualifiedPrizes(Convert.ToDouble(txtQualifiedPrizes.Text));
            richTextBox1.AppendText(showPrizes);
        }

        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            if (manager.recordDonation(txtDonationPrizeID.Text, Convert.ToInt16(txtNumber.Text), txtDonorID.Text, Convert.ToDouble(txtDonationAmount.Text), txtDonationDate.Text, txtDonationID.Text) == true)
            {                
                string messageDonation = manager.addDonation(txtDonationID.Text, txtDonationDate.Text, txtDonorID.Text, txtDonationPrizeID.Text, Convert.ToDouble(txtDonationAmount.Text));                
                MessageBox.Show(messageDonation);   
            }
            else
            {
                MessageBox.Show("There are " + manager.getCurrentAvailable(txtDonationPrizeID.Text) + " prizes left.\nDonation "+ txtDonationID.Text + " could not be added");
            }          
        }

        private void btnListDonors_Click(object sender, EventArgs e)
        {
            string viewDonors = manager.listDonors();
            MessageBox.Show(viewDonors);
        }

        private void btnListDonations_Click(object sender, EventArgs e)
        {
            string viewDonations = manager.listDonations();
            MessageBox.Show(viewDonations); 
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            string messageDonor = manager.addDonor(txtDonorFirstname.Text, txtDonorLastname.Text, txtDonorID.Text, txtDonorAddress.Text, txtDonorPhone.Text, txtCardNumber.Text, txtExpiryDate.Text, Convert.ToChar(getCreditCardType()));
            MessageBox.Show(messageDonor);
        }

        private void btnSaveDonorInfo_Click(object sender, EventArgs e)
        {
            manager.saveDonorInfo(txtDonorFirstname.Text, txtDonorLastname.Text, txtDonorID.Text, txtDonorAddress.Text, txtDonorPhone.Text, txtCardNumber.Text, txtExpiryDate.Text, Convert.ToChar(getCreditCardType()));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtQualifiedPrizes.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
            txtDonorFirstname.Clear();
            txtDonorLastname.Clear();
            txtDonorAddress.Clear();
            txtDonorPhone.Clear();
            txtDonationID.Clear();
            txtDonationAmount.Clear();
            txtDonationDate.Clear();
            txtCardNumber.Clear();
            txtExpiryDate.Clear();
            txtDonationPrizeID.Clear();
            txtNumber.Clear();
            radioBtnAmex.Checked = false;
            radioBtnMC.Checked = false;
            radioBtnVISA.Checked = false;
            richTextBox1.Clear();
            txtQualifiedPrizes.Clear();
        }

    }
}
