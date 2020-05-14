namespace SignChat_Maintenance
{
    partial class FrmCollectionDetails
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_sign = new System.Windows.Forms.DataGridView();
            this.Meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatasetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_collectionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_collectionId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_signNum = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linklbl_orgDetails = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_organisation = new System.Windows.Forms.TextBox();
            this.txt_orgTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_orgEmail = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_orgId = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_contactPerson = new System.Windows.Forms.TextBox();
            this.txt_contactPersonTel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_contactPersonEmail = new System.Windows.Forms.TextBox();
            this.txt_contactPersonTitle = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sign)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 49);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "COLLECTION DETAILS";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(654, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_sign);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(600, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(190, 395);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign";
            // 
            // dgv_sign
            // 
            this.dgv_sign.AllowUserToAddRows = false;
            this.dgv_sign.AllowUserToDeleteRows = false;
            this.dgv_sign.AllowUserToResizeRows = false;
            this.dgv_sign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meaning,
            this.DatasetNum});
            this.dgv_sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sign.Location = new System.Drawing.Point(5, 48);
            this.dgv_sign.Name = "dgv_sign";
            this.dgv_sign.RowHeadersVisible = false;
            this.dgv_sign.RowTemplate.Height = 24;
            this.dgv_sign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sign.Size = new System.Drawing.Size(180, 342);
            this.dgv_sign.TabIndex = 1;
            // 
            // Meaning
            // 
            this.Meaning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Meaning.HeaderText = "Meaning";
            this.Meaning.Name = "Meaning";
            this.Meaning.ReadOnly = true;
            // 
            // DatasetNum
            // 
            this.DatasetNum.HeaderText = "No. of Dataset";
            this.DatasetNum.Name = "DatasetNum";
            this.DatasetNum.ReadOnly = true;
            this.DatasetNum.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 27);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::SignChat_Maintenance.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(160, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(595, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 395);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_collectionName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_collectionId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_signNum, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Location = new System.Drawing.Point(103, 30);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(191, 23);
            this.txt_password.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Collection ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_collectionName
            // 
            this.txt_collectionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_collectionName.Location = new System.Drawing.Point(390, 3);
            this.txt_collectionName.Name = "txt_collectionName";
            this.txt_collectionName.Size = new System.Drawing.Size(192, 23);
            this.txt_collectionName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_collectionId
            // 
            this.txt_collectionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_collectionId.Location = new System.Drawing.Point(103, 3);
            this.txt_collectionId.Name = "txt_collectionId";
            this.txt_collectionId.Size = new System.Drawing.Size(191, 23);
            this.txt_collectionId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "No. of sign";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_signNum
            // 
            this.lbl_signNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_signNum.AutoSize = true;
            this.lbl_signNum.Location = new System.Drawing.Point(390, 31);
            this.lbl_signNum.Name = "lbl_signNum";
            this.lbl_signNum.Size = new System.Drawing.Size(17, 18);
            this.lbl_signNum.TabIndex = 5;
            this.lbl_signNum.Text = "0";
            this.lbl_signNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 7);
            this.panel4.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(585, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Person";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linklbl_orgDetails);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(5, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 129);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Organisation";
            // 
            // linklbl_orgDetails
            // 
            this.linklbl_orgDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklbl_orgDetails.AutoSize = true;
            this.linklbl_orgDetails.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_orgDetails.Location = new System.Drawing.Point(483, 104);
            this.linklbl_orgDetails.Name = "linklbl_orgDetails";
            this.linklbl_orgDetails.Size = new System.Drawing.Size(89, 18);
            this.linklbl_orgDetails.TabIndex = 1;
            this.linklbl_orgDetails.TabStop = true;
            this.linklbl_orgDetails.Text = "View Details";
            this.linklbl_orgDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_orgDetails_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_organisation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_orgTel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_orgEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_address, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_orgId, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(569, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_organisation
            // 
            this.txt_organisation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_organisation.Location = new System.Drawing.Point(83, 3);
            this.txt_organisation.Name = "txt_organisation";
            this.txt_organisation.Size = new System.Drawing.Size(229, 23);
            this.txt_organisation.TabIndex = 0;
            // 
            // txt_orgTel
            // 
            this.txt_orgTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orgTel.Location = new System.Drawing.Point(378, 30);
            this.txt_orgTel.Name = "txt_orgTel";
            this.txt_orgTel.Size = new System.Drawing.Size(188, 23);
            this.txt_orgTel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_orgEmail
            // 
            this.txt_orgEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orgEmail.Location = new System.Drawing.Point(83, 30);
            this.txt_orgEmail.Name = "txt_orgEmail";
            this.txt_orgEmail.Size = new System.Drawing.Size(229, 23);
            this.txt_orgEmail.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Location = new System.Drawing.Point(83, 57);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(229, 23);
            this.txt_address.TabIndex = 4;
            // 
            // txt_orgId
            // 
            this.txt_orgId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orgId.Location = new System.Drawing.Point(378, 3);
            this.txt_orgId.Name = "txt_orgId";
            this.txt_orgId.Size = new System.Drawing.Size(188, 23);
            this.txt_orgId.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(569, 5);
            this.panel7.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_contactPerson, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_contactPersonTel, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_contactPersonEmail, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_contactPersonTitle, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(575, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Title";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_contactPerson
            // 
            this.txt_contactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contactPerson.Location = new System.Drawing.Point(83, 3);
            this.txt_contactPerson.Name = "txt_contactPerson";
            this.txt_contactPerson.Size = new System.Drawing.Size(201, 23);
            this.txt_contactPerson.TabIndex = 0;
            // 
            // txt_contactPersonTel
            // 
            this.txt_contactPersonTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contactPersonTel.Location = new System.Drawing.Point(370, 30);
            this.txt_contactPersonTel.Name = "txt_contactPersonTel";
            this.txt_contactPersonTel.Size = new System.Drawing.Size(202, 23);
            this.txt_contactPersonTel.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Email";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Tel";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_contactPersonEmail
            // 
            this.txt_contactPersonEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contactPersonEmail.Location = new System.Drawing.Point(83, 30);
            this.txt_contactPersonEmail.Name = "txt_contactPersonEmail";
            this.txt_contactPersonEmail.Size = new System.Drawing.Size(201, 23);
            this.txt_contactPersonEmail.TabIndex = 2;
            // 
            // txt_contactPersonTitle
            // 
            this.txt_contactPersonTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contactPersonTitle.Location = new System.Drawing.Point(370, 3);
            this.txt_contactPersonTitle.Name = "txt_contactPersonTitle";
            this.txt_contactPersonTitle.Size = new System.Drawing.Size(202, 23);
            this.txt_contactPersonTitle.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 5);
            this.panel5.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(484, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 334);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(585, 44);
            this.panel8.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmCollectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCollectionDetails";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Text = "FrmOrganisationList";
            this.VisibleChanged += new System.EventHandler(this.FrmCollectionDetails_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sign)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_sign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatasetNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_collectionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_collectionId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_signNum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_contactPerson;
        private System.Windows.Forms.TextBox txt_contactPersonTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_contactPersonEmail;
        private System.Windows.Forms.TextBox txt_contactPersonTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_organisation;
        private System.Windows.Forms.TextBox txt_orgTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orgEmail;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_orgId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.LinkLabel linklbl_orgDetails;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}