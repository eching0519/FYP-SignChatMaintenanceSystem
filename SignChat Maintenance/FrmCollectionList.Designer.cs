namespace SignChat_Maintenance
{
    partial class FrmCollectionList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_collection = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatasetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_collection)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "SIGN COLLECTION";
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
            this.button1.Location = new System.Drawing.Point(634, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_collection);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(780, 395);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            this.Organisation,
            this.signNum,
            this.DatasetNum});
            this.dgv_collection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_collection.Location = new System.Drawing.Point(5, 48);
            this.dgv_collection.Name = "dgv_collection";
            this.dgv_collection.RowHeadersVisible = false;
            this.dgv_collection.RowTemplate.Height = 24;
            this.dgv_collection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_collection.Size = new System.Drawing.Size(770, 342);
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
            // Organisation
            // 
            this.Organisation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Organisation.HeaderText = "Organisation";
            this.Organisation.Name = "Organisation";
            this.Organisation.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 27);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(639, 0);
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
            this.label1.Location = new System.Drawing.Point(586, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // FrmCollectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCollectionList";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Text = "FrmOrganisationList";
            this.VisibleChanged += new System.EventHandler(this.FrmCollectionList_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_collection)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_collection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn signNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatasetNum;
    }
}