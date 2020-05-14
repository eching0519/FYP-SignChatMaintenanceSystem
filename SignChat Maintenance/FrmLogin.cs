using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignChat_Maintenance
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            tableLayoutPanel.SetRowSpan(btn_login, 2);
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void Login()
        {
            SignChatDB db = new SignChatDB();
            String username = txt_username.Text;
            String password = txt_password.Text;
            bool validate = db.LoginValidation(username, password);
            if (validate)
            {
                FrmHomepage frm = new FrmHomepage(username);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = this.Location;
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry. Invalid Login.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }
    }
}
