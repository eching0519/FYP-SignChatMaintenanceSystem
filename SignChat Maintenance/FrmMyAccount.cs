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
    public partial class FrmMyAccount : Form
    {
        private String adminUsername;
        private SignChatDB db;

        public FrmMyAccount(String username)
        {
            InitializeComponent();

            this.adminUsername = username;
            db = new SignChatDB();
            txt_username.Text = username;
            txt_username.ReadOnly = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void SubmitForm()
        {
            if (!ValidateFormInput())
            {
                return;
            }


            UpdateDatabase();
            MessageBox.Show("Update successful");
            txt_currentPw.Clear();
            txt_newPw.Clear();
            txt_reTypeNewPw.Clear();
        }

        private bool ValidateFormInput()
        {
            bool isValid = true;

            List<Control> controls = new List<Control>();
            controls.Add(txt_username);
            controls.Add(txt_currentPw);
            controls.Add(txt_newPw);
            controls.Add(txt_reTypeNewPw);
            foreach(Control c in controls)
            {
                if (c.Text == "")
                {
                    errorProvider.SetError(c, "Required.");
                    errorProvider.SetIconPadding(c, -20);
                    isValid = false;
                }
                else
                {
                    errorProvider.SetError(c, "");
                }
            }

            if (!db.LoginValidation(adminUsername, txt_currentPw.Text)) 
            {
                errorProvider.SetError(txt_currentPw, "Invalid password.");
                errorProvider.SetIconPadding(txt_currentPw, -20);
                isValid = false;
            }

            if (txt_newPw.Text != txt_reTypeNewPw.Text) 
            {
                errorProvider.SetError(txt_reTypeNewPw, "Does not match with the new password.");
                errorProvider.SetIconPadding(txt_reTypeNewPw, -20);
                isValid = false;
            }

            return isValid;
        }

        private void UpdateDatabase()
        {
            administrator ad = new administrator
            {
                username = adminUsername,
                password = txt_newPw.Text
            };
            db.UpdateAdministrator(ad);
        }
    }
}
