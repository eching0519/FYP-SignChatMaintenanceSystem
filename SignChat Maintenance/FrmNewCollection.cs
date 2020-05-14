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
    public partial class FrmNewCollection : Form
    {
        private FrmHomepage parent;

        private SignChatDB db;
        private List<organisation> organisations;
        
        private TextBox txt_organisation;

        public FrmNewCollection(FrmHomepage parent)
        {
            InitializeComponent();

            this.parent = parent;
            tableLayoutPanel2.SetColumnSpan(txt_address, 3);
            tableLayoutPanel2.SetColumnSpan(ckBox_newOrg, 2);

            db = new SignChatDB();
            organisations = db.GetOrganisationList();

            // set organisation cbBox
            cbBox_organisation.TabIndex = 0;
            foreach(organisation o in organisations)
            {
                String item = String.Format("{0,-10}{1}", o.id, o.name);
                cbBox_organisation.Items.Add(item);
            }
            // set organisation txt
            txt_organisation = new TextBox();
            txt_organisation.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            txt_organisation.TabIndex = 0;

            txt_orgEmail.ReadOnly = true;
            txt_orgTel.ReadOnly = true;
            txt_address.ReadOnly = true;
        }

        public FrmNewCollection(FrmHomepage parent, int organisationId):this(parent)
        {
            organisation selectedOrg = organisations.FirstOrDefault(i => i.id == organisationId);
            int sIndex = organisations.IndexOf(selectedOrg);
            cbBox_organisation.SelectedIndex = sIndex;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you want to leave without saving the data?", "You have not saved.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.No))
            {
                return;
            }
            
            parent.Backward();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(!ValidateForm())
            {
                return;
            }

            // New sign collection
            signcollection sc = new signcollection
            {
                collectionId = txt_collectionId.Text,
                password = txt_password.Text,
                name = txt_collectionName.Text,
                contactPerson = txt_contactPerson.Text,
                contactPersonEmail = txt_contactPersonEmail.Text,
                contactPersonTel = txt_contactPersonTel.Text,
                contactPersonTitle = txt_contactPersonTitle.Text,
                organisationId = organisations.ElementAt(cbBox_organisation.SelectedIndex).id
            };

            // New organisation
            if (ckBox_newOrg.Checked)
            {
                organisation org = new organisation
                {
                    name = txt_organisation.Text,
                    email = txt_orgEmail.Text,
                    address = txt_address.Text,
                    tel = txt_orgTel.Text
                };
                sc.organisationId = db.NewOrganisation(org);
            }

            db.NewCollection(sc);

            // Change page
            FrmCollectionDetails frm = new FrmCollectionDetails(parent, sc.collectionId);
            parent.ReplaceWith(frm);

        }

        private bool ValidateForm()
        {
            bool validate = true;
            List<Control> requiredControls = new List<Control>();
            requiredControls.Add(txt_collectionId);
            requiredControls.Add(txt_collectionName);
            requiredControls.Add(txt_password);
            requiredControls.Add(txt_orgEmail);
            requiredControls.Add(txt_orgTel);
            requiredControls.Add(txt_address);
            requiredControls.Add(txt_contactPerson);
            foreach(Control c in requiredControls)
            {
                if(c.Text=="")
                {
                    errorProvider.SetError(c, "Required.");
                    errorProvider.SetIconPadding(c, -20);
                    validate = false;
                } else
                {
                    errorProvider.SetError(c, "");
                }
            }
            if (txt_collectionId.Text != "")
            {
                signcollection sc = db.GetSignCollection(txt_collectionId.Text);
                if (sc != null)
                {
                    errorProvider.SetError(txt_collectionId, "Collection ID is in used.");
                    errorProvider.SetIconPadding(txt_collectionId, -20);
                    validate = false;
                }
                else
                {
                    errorProvider.SetError(txt_collectionId, "");
                }
            }

            if (ckBox_newOrg.Checked && txt_organisation.Text == "") 
            {
                errorProvider.SetError(txt_organisation, "Required.");
                errorProvider.SetIconPadding(txt_organisation, -20);
                validate = false;
            } else if (!ckBox_newOrg.Checked && cbBox_organisation.SelectedIndex < 0)
            {
                errorProvider.SetError(cbBox_organisation, "Required.");
                errorProvider.SetIconPadding(cbBox_organisation, -20);
                validate = false;
            }
            else
            {
                errorProvider.SetError(txt_organisation, "");
                errorProvider.SetError(cbBox_organisation, "");
            }
            
            if (txt_contactPersonEmail.Text == "" && txt_contactPersonTel.Text == "") 
            {
                errorProvider.SetError(txt_contactPersonEmail, "Please enter at least one of the contact method.");
                errorProvider.SetIconPadding(txt_contactPersonEmail, -20);
                errorProvider.SetError(txt_contactPersonTel, "Please enter at least one of the contact method.");
                errorProvider.SetIconPadding(txt_contactPersonTel, -20);
                validate = false;
            }
            else
            {
                errorProvider.SetError(txt_contactPersonEmail, "");
                errorProvider.SetError(txt_contactPersonTel, "");
            }
            return validate;
        }

        private void ckBox_newOrg_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBox_newOrg.Checked)
            {
                this.tableLayoutPanel2.Controls.Remove(cbBox_organisation);
                this.tableLayoutPanel2.Controls.Add(txt_organisation, 1, 0);
                txt_orgEmail.Text = "";
                txt_orgTel.Text = "";
                txt_address.Text = "";
                txt_orgEmail.ReadOnly = false;
                txt_orgTel.ReadOnly = false;
                txt_address.ReadOnly = false;
            } else
            {
                this.tableLayoutPanel2.Controls.Remove(txt_organisation);
                this.tableLayoutPanel2.Controls.Add(cbBox_organisation, 1, 0);

                int temp = cbBox_organisation.SelectedIndex;
                cbBox_organisation.SelectedIndex = -1;
                cbBox_organisation.SelectedIndex = temp;

                txt_orgEmail.ReadOnly = true;
                txt_orgTel.ReadOnly = true;
                txt_address.ReadOnly = true;
            }
        }

        private void cbBox_organisation_SelectedIndexChanged(object sender, EventArgs e)
        {
            organisation org;
            if (cbBox_organisation.SelectedIndex < 0)
            {
                org = new organisation();
            } else {
                org = organisations.ElementAt(cbBox_organisation.SelectedIndex);
            }
            txt_orgEmail.Text = org.email;
            txt_orgTel.Text = org.tel;
            txt_address.Text = org.address;
        }
    }

}
