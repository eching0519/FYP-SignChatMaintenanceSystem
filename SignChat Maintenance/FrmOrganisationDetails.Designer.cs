namespace SignChat_Maintenance
{
    partial class FrmOrganisationDetails
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_collection = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatasetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklbl_addCollection = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_organisation = new System.Windows.Forms.TextBox();
            this.txt_orgTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_orgEmail = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_orgId = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_collection)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "ORGANISATION";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(780, 395);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_collection);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sign Collection";
            // 
            // dgv_collection
            // 
            this.dgv_collection.AllowUserToAddRows = false;
            this.dgv_collection.AllowUserToDeleteRows = false;
            this.dgv_collection.AllowUserToResizeRows = false;
            this.dgv_collection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_collection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Collection,
            this.signNum,
            this.DatasetNum,
            this.contactPerson});
            this.dgv_collection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_collection.Location = new System.Drawing.Point(3, 46);
            this.dgv_collection.Name = "dgv_collection";
            this.dgv_collection.RowHeadersVisible = false;
            this.dgv_collection.RowTemplate.Height = 24;
            this.dgv_collection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_collection.Size = new System.Drawing.Size(764, 188);
            this.dgv_collection.TabIndex = 1;
            this.dgv_collection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_collection_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Login ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Collection
            // 
            this.Collection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Collection.HeaderText = "Collection";
            this.Collection.Name = "Collection";
            this.Collection.ReadOnly = true;
            // 
            // signNum
            // 
            this.signNum.HeaderText = "No. of Sign";
            this.signNum.Name = "signNum";
            this.signNum.ReadOnly = true;
            this.signNum.Width = 70;
            // 
            // DatasetNum
            // 
            this.DatasetNum.HeaderText = "No. of Dataset";
            this.DatasetNum.Name = "DatasetNum";
            this.DatasetNum.ReadOnly = true;
            this.DatasetNum.Width = 70;
            // 
            // contactPerson
            // 
            this.contactPerson.HeaderText = "Contact Person";
            this.contactPerson.Name = "contactPerson";
            this.contactPerson.ReadOnly = true;
            this.contactPerson.Width = 140;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linklbl_addCollection);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 27);
            this.panel2.TabIndex = 0;
            // 
            // linklbl_addCollection
            // 
            this.linklbl_addCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linklbl_addCollection.AutoSize = true;
            this.linklbl_addCollection.Location = new System.Drawing.Point(0, 9);
            this.linklbl_addCollection.Name = "linklbl_addCollection";
            this.linklbl_addCollection.Size = new System.Drawing.Size(111, 18);
            this.linklbl_addCollection.TabIndex = 2;
            this.linklbl_addCollection.TabStop = true;
            this.linklbl_addCollection.Text = "+Add Collection";
            this.linklbl_addCollection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(633, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(5, 109);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(770, 44);
            this.panel8.TabIndex = 11;
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
            this.button2.Location = new System.Drawing.Point(669, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 7);
            this.panel4.TabIndex = 9;
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
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_orgEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_address, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_orgId, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 81);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.label8.Location = new System.Drawing.Point(460, 4);
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
            this.txt_organisation.Size = new System.Drawing.Size(340, 23);
            this.txt_organisation.TabIndex = 0;
            // 
            // txt_orgTel
            // 
            this.txt_orgTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orgTel.Location = new System.Drawing.Point(489, 30);
            this.txt_orgTel.Name = "txt_orgTel";
            this.txt_orgTel.Size = new System.Drawing.Size(278, 23);
            this.txt_orgTel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 31);
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
            this.txt_orgEmail.Size = new System.Drawing.Size(340, 23);
            this.txt_orgEmail.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Location = new System.Drawing.Point(83, 57);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(340, 23);
            this.txt_address.TabIndex = 4;
            // 
            // txt_orgId
            // 
            this.txt_orgId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orgId.Location = new System.Drawing.Point(489, 3);
            this.txt_orgId.Name = "txt_orgId";
            this.txt_orgId.Size = new System.Drawing.Size(278, 23);
            this.txt_orgId.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmOrganisationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrganisationDetails";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Text = "FrmOrganisationList";
            this.VisibleChanged += new System.EventHandler(this.FrmOrganisationDetails_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_collection)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_collection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_organisation;
        private System.Windows.Forms.TextBox txt_orgTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orgEmail;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_orgId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linklbl_addCollection;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection;
        private System.Windows.Forms.DataGridViewTextBoxColumn signNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatasetNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPerson;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
    }
}