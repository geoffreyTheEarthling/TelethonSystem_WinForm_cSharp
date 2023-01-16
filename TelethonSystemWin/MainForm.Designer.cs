namespace TelethonSystemWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSponsID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinDonationLimit = new System.Windows.Forms.TextBox();
            this.txtPrizeQuantity = new System.Windows.Forms.TextBox();
            this.txtPrizeValue = new System.Windows.Forms.TextBox();
            this.txtPrizeDescription = new System.Windows.Forms.TextBox();
            this.txtPrizeID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSponsorID = new System.Windows.Forms.TextBox();
            this.txtSponsorLastName = new System.Windows.Forms.TextBox();
            this.txtSponsorFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPrize = new System.Windows.Forms.Button();
            this.btnViewSponsors = new System.Windows.Forms.Button();
            this.btnViewPrizes = new System.Windows.Forms.Button();
            this.btnAddSponsor = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.btnSaveDonorInfo = new System.Windows.Forms.Button();
            this.btnListDonors = new System.Windows.Forms.Button();
            this.btnListDonations = new System.Windows.Forms.Button();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtQualifiedPrizes = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDonationPrizeID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnShowPrizes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnAmex = new System.Windows.Forms.RadioButton();
            this.radioBtnMC = new System.Windows.Forms.RadioButton();
            this.radioBtnVISA = new System.Windows.Forms.RadioButton();
            this.txtDonationDate = new System.Windows.Forms.TextBox();
            this.txtDonationAmount = new System.Windows.Forms.TextBox();
            this.txtDonationID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDonorPhone = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDonorAddress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDonorLastname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDonorFirstname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.tab1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 594);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 472);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(660, 116);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tab2);
            this.tab1.Location = new System.Drawing.Point(6, 33);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(585, 433);
            this.tab1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSponsID);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtMinDonationLimit);
            this.tabPage1.Controls.Add(this.txtPrizeQuantity);
            this.tabPage1.Controls.Add(this.txtPrizeValue);
            this.tabPage1.Controls.Add(this.txtPrizeDescription);
            this.tabPage1.Controls.Add(this.txtPrizeID);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSponsorID);
            this.tabPage1.Controls.Add(this.txtSponsorLastName);
            this.tabPage1.Controls.Add(this.txtSponsorFirstName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddPrize);
            this.tabPage1.Controls.Add(this.btnViewSponsors);
            this.tabPage1.Controls.Add(this.btnViewPrizes);
            this.tabPage1.Controls.Add(this.btnAddSponsor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sponsors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSponsID
            // 
            this.txtSponsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSponsID.Location = new System.Drawing.Point(389, 126);
            this.txtSponsID.Name = "txtSponsID";
            this.txtSponsID.Size = new System.Drawing.Size(155, 22);
            this.txtSponsID.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "SponsorID";
            // 
            // txtMinDonationLimit
            // 
            this.txtMinDonationLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinDonationLimit.Location = new System.Drawing.Point(444, 218);
            this.txtMinDonationLimit.Name = "txtMinDonationLimit";
            this.txtMinDonationLimit.Size = new System.Drawing.Size(100, 22);
            this.txtMinDonationLimit.TabIndex = 9;
            // 
            // txtPrizeQuantity
            // 
            this.txtPrizeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrizeQuantity.Location = new System.Drawing.Point(444, 184);
            this.txtPrizeQuantity.Name = "txtPrizeQuantity";
            this.txtPrizeQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtPrizeQuantity.TabIndex = 8;
            // 
            // txtPrizeValue
            // 
            this.txtPrizeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrizeValue.Location = new System.Drawing.Point(444, 156);
            this.txtPrizeValue.Name = "txtPrizeValue";
            this.txtPrizeValue.Size = new System.Drawing.Size(100, 22);
            this.txtPrizeValue.TabIndex = 7;
            // 
            // txtPrizeDescription
            // 
            this.txtPrizeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrizeDescription.Location = new System.Drawing.Point(389, 92);
            this.txtPrizeDescription.Name = "txtPrizeDescription";
            this.txtPrizeDescription.Size = new System.Drawing.Size(155, 22);
            this.txtPrizeDescription.TabIndex = 5;
            // 
            // txtPrizeID
            // 
            this.txtPrizeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrizeID.Location = new System.Drawing.Point(389, 64);
            this.txtPrizeID.Name = "txtPrizeID";
            this.txtPrizeID.Size = new System.Drawing.Size(155, 22);
            this.txtPrizeID.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Value per Prize:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "How many?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Minimum donation\r\nlimit?\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prize ID:";
            // 
            // txtSponsorID
            // 
            this.txtSponsorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSponsorID.Location = new System.Drawing.Point(101, 126);
            this.txtSponsorID.Multiline = true;
            this.txtSponsorID.Name = "txtSponsorID";
            this.txtSponsorID.Size = new System.Drawing.Size(122, 22);
            this.txtSponsorID.TabIndex = 3;
            // 
            // txtSponsorLastName
            // 
            this.txtSponsorLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSponsorLastName.Location = new System.Drawing.Point(101, 95);
            this.txtSponsorLastName.Multiline = true;
            this.txtSponsorLastName.Name = "txtSponsorLastName";
            this.txtSponsorLastName.Size = new System.Drawing.Size(122, 22);
            this.txtSponsorLastName.TabIndex = 2;
            // 
            // txtSponsorFirstName
            // 
            this.txtSponsorFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSponsorFirstName.Location = new System.Drawing.Point(101, 67);
            this.txtSponsorFirstName.Multiline = true;
            this.txtSponsorFirstName.Name = "txtSponsorFirstName";
            this.txtSponsorFirstName.Size = new System.Drawing.Size(122, 22);
            this.txtSponsorFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sponsor ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prize Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sponsor Information:";
            // 
            // btnAddPrize
            // 
            this.btnAddPrize.Location = new System.Drawing.Point(421, 323);
            this.btnAddPrize.Name = "btnAddPrize";
            this.btnAddPrize.Size = new System.Drawing.Size(123, 31);
            this.btnAddPrize.TabIndex = 11;
            this.btnAddPrize.Text = "Add Prize";
            this.btnAddPrize.UseVisualStyleBackColor = true;
            this.btnAddPrize.Click += new System.EventHandler(this.btnAddPrize_Click);
            // 
            // btnViewSponsors
            // 
            this.btnViewSponsors.Location = new System.Drawing.Point(292, 360);
            this.btnViewSponsors.Name = "btnViewSponsors";
            this.btnViewSponsors.Size = new System.Drawing.Size(123, 31);
            this.btnViewSponsors.TabIndex = 12;
            this.btnViewSponsors.Text = "View Sponsors";
            this.btnViewSponsors.UseVisualStyleBackColor = true;
            this.btnViewSponsors.Click += new System.EventHandler(this.btnViewSponsors_Click);
            // 
            // btnViewPrizes
            // 
            this.btnViewPrizes.Location = new System.Drawing.Point(421, 360);
            this.btnViewPrizes.Name = "btnViewPrizes";
            this.btnViewPrizes.Size = new System.Drawing.Size(123, 31);
            this.btnViewPrizes.TabIndex = 13;
            this.btnViewPrizes.Text = "View Prizes";
            this.btnViewPrizes.UseVisualStyleBackColor = true;
            this.btnViewPrizes.Click += new System.EventHandler(this.btnViewPrizes_Click);
            // 
            // btnAddSponsor
            // 
            this.btnAddSponsor.Location = new System.Drawing.Point(292, 323);
            this.btnAddSponsor.Name = "btnAddSponsor";
            this.btnAddSponsor.Size = new System.Drawing.Size(123, 31);
            this.btnAddSponsor.TabIndex = 10;
            this.btnAddSponsor.Text = "Add Sponsor";
            this.btnAddSponsor.UseVisualStyleBackColor = true;
            this.btnAddSponsor.Click += new System.EventHandler(this.btnAddSponsor_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnClear);
            this.tab2.Controls.Add(this.btnAddDonor);
            this.tab2.Controls.Add(this.btnSaveDonorInfo);
            this.tab2.Controls.Add(this.btnListDonors);
            this.tab2.Controls.Add(this.btnListDonations);
            this.tab2.Controls.Add(this.btnAddDonation);
            this.tab2.Controls.Add(this.groupBox4);
            this.tab2.Controls.Add(this.groupBox2);
            this.tab2.Controls.Add(this.txtDonationDate);
            this.tab2.Controls.Add(this.txtDonationAmount);
            this.tab2.Controls.Add(this.txtDonationID);
            this.tab2.Controls.Add(this.label21);
            this.tab2.Controls.Add(this.label20);
            this.tab2.Controls.Add(this.label19);
            this.tab2.Controls.Add(this.txtDonorPhone);
            this.tab2.Controls.Add(this.label18);
            this.tab2.Controls.Add(this.txtDonorAddress);
            this.tab2.Controls.Add(this.label17);
            this.tab2.Controls.Add(this.txtDonorLastname);
            this.tab2.Controls.Add(this.label16);
            this.tab2.Controls.Add(this.txtDonorFirstname);
            this.tab2.Controls.Add(this.label15);
            this.tab2.Controls.Add(this.txtDonorID);
            this.tab2.Controls.Add(this.label14);
            this.tab2.Controls.Add(this.label13);
            this.tab2.Controls.Add(this.label12);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(577, 404);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Donors";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(434, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(434, 227);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(126, 23);
            this.btnAddDonor.TabIndex = 24;
            this.btnAddDonor.Text = "Add Donor";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // btnSaveDonorInfo
            // 
            this.btnSaveDonorInfo.Location = new System.Drawing.Point(434, 343);
            this.btnSaveDonorInfo.Name = "btnSaveDonorInfo";
            this.btnSaveDonorInfo.Size = new System.Drawing.Size(126, 23);
            this.btnSaveDonorInfo.TabIndex = 23;
            this.btnSaveDonorInfo.Text = "Save Donor Info";
            this.btnSaveDonorInfo.UseVisualStyleBackColor = true;
            this.btnSaveDonorInfo.Click += new System.EventHandler(this.btnSaveDonorInfo_Click);
            // 
            // btnListDonors
            // 
            this.btnListDonors.Location = new System.Drawing.Point(434, 314);
            this.btnListDonors.Name = "btnListDonors";
            this.btnListDonors.Size = new System.Drawing.Size(126, 23);
            this.btnListDonors.TabIndex = 22;
            this.btnListDonors.Text = "List Donors";
            this.btnListDonors.UseVisualStyleBackColor = true;
            this.btnListDonors.Click += new System.EventHandler(this.btnListDonors_Click);
            // 
            // btnListDonations
            // 
            this.btnListDonations.Location = new System.Drawing.Point(434, 285);
            this.btnListDonations.Name = "btnListDonations";
            this.btnListDonations.Size = new System.Drawing.Size(126, 23);
            this.btnListDonations.TabIndex = 21;
            this.btnListDonations.Text = "List Donations";
            this.btnListDonations.UseVisualStyleBackColor = true;
            this.btnListDonations.Click += new System.EventHandler(this.btnListDonations_Click);
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(434, 256);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(126, 23);
            this.btnAddDonation.TabIndex = 20;
            this.btnAddDonation.Text = "Add Donation";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtQualifiedPrizes);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txtNumber);
            this.groupBox4.Controls.Add(this.txtDonationPrizeID);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.btnShowPrizes);
            this.groupBox4.Location = new System.Drawing.Point(272, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 161);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Award Prize:";
            // 
            // txtQualifiedPrizes
            // 
            this.txtQualifiedPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQualifiedPrizes.Location = new System.Drawing.Point(68, 126);
            this.txtQualifiedPrizes.Name = "txtQualifiedPrizes";
            this.txtQualifiedPrizes.Size = new System.Drawing.Size(60, 22);
            this.txtQualifiedPrizes.TabIndex = 26;
//            this.txtQualifiedPrizes.TextChanged += new System.EventHandler(this.txtQualifiedPrizes_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 16);
            this.label27.TabIndex = 25;
            this.label27.Text = "Value:";
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Location = new System.Drawing.Point(68, 96);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(60, 22);
            this.txtNumber.TabIndex = 24;
            // 
            // txtDonationPrizeID
            // 
            this.txtDonationPrizeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonationPrizeID.Location = new System.Drawing.Point(68, 65);
            this.txtDonationPrizeID.Name = "txtDonationPrizeID";
            this.txtDonationPrizeID.Size = new System.Drawing.Size(60, 22);
            this.txtDonationPrizeID.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 98);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 16);
            this.label26.TabIndex = 22;
            this.label26.Text = "Number:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 67);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 21;
            this.label25.Text = "Prize ID:";
            // 
            // btnShowPrizes
            // 
            this.btnShowPrizes.Location = new System.Drawing.Point(9, 21);
            this.btnShowPrizes.Name = "btnShowPrizes";
            this.btnShowPrizes.Size = new System.Drawing.Size(126, 23);
            this.btnShowPrizes.TabIndex = 0;
            this.btnShowPrizes.Text = "Show Prizes";
            this.btnShowPrizes.UseVisualStyleBackColor = true;
            this.btnShowPrizes.Click += new System.EventHandler(this.btnShowPrizes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtExpiryDate);
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(272, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 140);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credit Card Information:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(147, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 16);
            this.label24.TabIndex = 21;
            this.label24.Text = "mm/yy";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpiryDate.Location = new System.Drawing.Point(81, 106);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(60, 22);
            this.txtExpiryDate.TabIndex = 19;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.Location = new System.Drawing.Point(81, 78);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(138, 22);
            this.txtCardNumber.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 16);
            this.label23.TabIndex = 20;
            this.label23.Text = "Expiry:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 16);
            this.label22.TabIndex = 19;
            this.label22.Text = "Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnAmex);
            this.groupBox3.Controls.Add(this.radioBtnMC);
            this.groupBox3.Controls.Add(this.radioBtnVISA);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 46);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Card type:";
            // 
            // radioBtnAmex
            // 
            this.radioBtnAmex.AutoSize = true;
            this.radioBtnAmex.Location = new System.Drawing.Point(136, 20);
            this.radioBtnAmex.Name = "radioBtnAmex";
            this.radioBtnAmex.Size = new System.Drawing.Size(65, 20);
            this.radioBtnAmex.TabIndex = 20;
            this.radioBtnAmex.TabStop = true;
            this.radioBtnAmex.Text = "AMEX";
            this.radioBtnAmex.UseVisualStyleBackColor = true;
            // 
            // radioBtnMC
            // 
            this.radioBtnMC.AutoSize = true;
            this.radioBtnMC.Location = new System.Drawing.Point(82, 20);
            this.radioBtnMC.Name = "radioBtnMC";
            this.radioBtnMC.Size = new System.Drawing.Size(48, 20);
            this.radioBtnMC.TabIndex = 20;
            this.radioBtnMC.TabStop = true;
            this.radioBtnMC.Text = "MC";
            this.radioBtnMC.UseVisualStyleBackColor = true;
            // 
            // radioBtnVISA
            // 
            this.radioBtnVISA.AutoSize = true;
            this.radioBtnVISA.Location = new System.Drawing.Point(18, 20);
            this.radioBtnVISA.Name = "radioBtnVISA";
            this.radioBtnVISA.Size = new System.Drawing.Size(58, 20);
            this.radioBtnVISA.TabIndex = 19;
            this.radioBtnVISA.TabStop = true;
            this.radioBtnVISA.Text = "VISA";
            this.radioBtnVISA.UseVisualStyleBackColor = true;
            // 
            // txtDonationDate
            // 
            this.txtDonationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonationDate.Location = new System.Drawing.Point(122, 341);
            this.txtDonationDate.Name = "txtDonationDate";
            this.txtDonationDate.Size = new System.Drawing.Size(126, 22);
            this.txtDonationDate.TabIndex = 17;
            // 
            // txtDonationAmount
            // 
            this.txtDonationAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonationAmount.Location = new System.Drawing.Point(122, 313);
            this.txtDonationAmount.Name = "txtDonationAmount";
            this.txtDonationAmount.Size = new System.Drawing.Size(126, 22);
            this.txtDonationAmount.TabIndex = 16;
            // 
            // txtDonationID
            // 
            this.txtDonationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonationID.Location = new System.Drawing.Point(122, 282);
            this.txtDonationID.Name = "txtDonationID";
            this.txtDonationID.Size = new System.Drawing.Size(126, 22);
            this.txtDonationID.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 347);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 16);
            this.label20.TabIndex = 13;
            this.label20.Text = "Amount:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Donation ID:";
            // 
            // txtDonorPhone
            // 
            this.txtDonorPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonorPhone.Location = new System.Drawing.Point(122, 176);
            this.txtDonorPhone.Name = "txtDonorPhone";
            this.txtDonorPhone.Size = new System.Drawing.Size(126, 22);
            this.txtDonorPhone.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Phone:";
            // 
            // txtDonorAddress
            // 
            this.txtDonorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonorAddress.Location = new System.Drawing.Point(122, 148);
            this.txtDonorAddress.Name = "txtDonorAddress";
            this.txtDonorAddress.Size = new System.Drawing.Size(126, 22);
            this.txtDonorAddress.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Address:";
            // 
            // txtDonorLastname
            // 
            this.txtDonorLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonorLastname.Location = new System.Drawing.Point(122, 120);
            this.txtDonorLastname.Name = "txtDonorLastname";
            this.txtDonorLastname.Size = new System.Drawing.Size(126, 22);
            this.txtDonorLastname.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Last name:";
            // 
            // txtDonorFirstname
            // 
            this.txtDonorFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonorFirstname.Location = new System.Drawing.Point(122, 92);
            this.txtDonorFirstname.Name = "txtDonorFirstname";
            this.txtDonorFirstname.Size = new System.Drawing.Size(126, 22);
            this.txtDonorFirstname.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "First name:";
            // 
            // txtDonorID
            // 
            this.txtDonorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonorID.Location = new System.Drawing.Point(122, 64);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.Size = new System.Drawing.Size(126, 22);
            this.txtDonorID.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Donor ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Donation Information:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Donor Information:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 615);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sponsor and Donor Information";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMinDonationLimit;
        private System.Windows.Forms.TextBox txtPrizeQuantity;
        private System.Windows.Forms.TextBox txtPrizeValue;
        private System.Windows.Forms.TextBox txtPrizeDescription;
        private System.Windows.Forms.TextBox txtPrizeID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSponsorID;
        private System.Windows.Forms.TextBox txtSponsorLastName;
        private System.Windows.Forms.TextBox txtSponsorFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPrize;
        private System.Windows.Forms.Button btnViewSponsors;
        private System.Windows.Forms.Button btnViewPrizes;
        private System.Windows.Forms.Button btnAddSponsor;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TextBox txtSponsID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonationDate;
        private System.Windows.Forms.TextBox txtDonationAmount;
        private System.Windows.Forms.TextBox txtDonationID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDonorPhone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDonorAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDonorLastname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDonorFirstname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveDonorInfo;
        private System.Windows.Forms.Button btnListDonors;
        private System.Windows.Forms.Button btnListDonations;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtDonationPrizeID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnShowPrizes;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtQualifiedPrizes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtnAmex;
        private System.Windows.Forms.RadioButton radioBtnMC;
        private System.Windows.Forms.RadioButton radioBtnVISA;
    }
}