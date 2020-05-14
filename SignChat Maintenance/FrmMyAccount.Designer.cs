namespace SignChat_Maintenance
{
    partial class FrmMyAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_currentPw = new System.Windows.Forms.TextBox();
            this.txt_newPw = new System.Windows.Forms.TextBox();
            this.txt_reTypeNewPw = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
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
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "MY ACCOUNT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(780, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_username, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_currentPw, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_newPw, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_reTypeNewPw, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Re-type New Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Location = new System.Drawing.Point(173, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(294, 23);
            this.txt_username.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_currentPw
            // 
            this.txt_currentPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_currentPw.Location = new System.Drawing.Point(173, 30);
            this.txt_currentPw.Name = "txt_currentPw";
            this.txt_currentPw.PasswordChar = '●';
            this.txt_currentPw.Size = new System.Drawing.Size(294, 23);
            this.txt_currentPw.TabIndex = 1;
            // 
            // txt_newPw
            // 
            this.txt_newPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_newPw.Location = new System.Drawing.Point(173, 57);
            this.txt_newPw.Name = "txt_newPw";
            this.txt_newPw.PasswordChar = '●';
            this.txt_newPw.Size = new System.Drawing.Size(294, 23);
            this.txt_newPw.TabIndex = 2;
            // 
            // txt_reTypeNewPw
            // 
            this.txt_reTypeNewPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_reTypeNewPw.Location = new System.Drawing.Point(173, 84);
            this.txt_reTypeNewPw.Name = "txt_reTypeNewPw";
            this.txt_reTypeNewPw.PasswordChar = '●';
            this.txt_reTypeNewPw.Size = new System.Drawing.Size(294, 23);
            this.txt_reTypeNewPw.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_submit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(10, 186);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(780, 44);
            this.panel8.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.BackColor = System.Drawing.Color.White;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_submit.FlatAppearance.BorderSize = 3;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_submit.Location = new System.Drawing.Point(679, 6);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 37);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmMyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMyAccount";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Text = "FrmOrganisationList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_currentPw;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newPw;
        private System.Windows.Forms.TextBox txt_reTypeNewPw;
    }
}