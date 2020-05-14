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
    public partial class FrmCollectionDetails : Form
    {
        private FrmHomepage parent;

        private SignChatDB db;
        private signcollection mySignCollection;
        private List<sign> mySigns;
        private organisation myOrganisation;

        private bool editMode;

        public FrmCollectionDetails(FrmHomepage parent, String collectionId)
        {
            InitializeComponent();

            this.parent = parent;
            tableLayoutPanel2.SetColumnSpan(txt_address, 3);
            
            db = new SignChatDB();
            mySignCollection = db.GetSignCollection(collectionId);
            mySigns = db.GetSigns(collectionId);
            myOrganisation = db.GetOrganisation(mySignCollection.organisationId);

            SetForm();
            editMode = false;
        }

        private void SetForm()
        {
            txt_collectionId.Text = mySignCollection.collectionId;
            txt_collectionName.Text = mySignCollection.name;
            txt_password.Text = mySignCollection.password;
            lbl_signNum.Text = mySigns.GroupBy(i => i.meaning).Count().ToString();

            txt_contactPerson.Text = mySignCollection.contactPerson;
            txt_contactPersonTitle.Text = mySignCollection.contactPersonTitle;
            txt_contactPersonEmail.Text = mySignCollection.contactPersonEmail;
            txt_contactPersonTel.Text = mySignCollection.contactPersonTel;

            txt_organisation.Text = myOrganisation.name;
            txt_orgId.Text = myOrganisation.id.ToString();
            txt_orgEmail.Text = myOrganisation.email;
            txt_orgTel.Text = myOrganisation.tel;
            txt_address.Text = myOrganisation.address;

            UpdateList(mySigns);

            txt_collectionId.ReadOnly = true;
            txt_collectionName.ReadOnly = true;
            txt_password.ReadOnly = true;

            txt_organisation.ReadOnly = true;
            txt_orgId.ReadOnly = true;
            txt_orgEmail.ReadOnly = true;
            txt_orgTel.ReadOnly = true;
            txt_address.ReadOnly = true;
            linklbl_orgDetails.Enabled = true;

            txt_contactPerson.ReadOnly = true;
            txt_contactPersonTitle.ReadOnly = true;
            txt_contactPersonEmail.ReadOnly = true;
            txt_contactPersonTel.ReadOnly = true;
        }

        public void UpdateList(List<sign> newList)
        {
            dgv_sign.Rows.Clear();

            var signList = newList.GroupBy(i => i.meaning).Select(group => new { Meaning = group.Key, Count = group.Count() }).ToList();

            foreach (var sign in signList)
            {
                dgv_sign.Rows.Add(sign.Meaning, sign.Count);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text.ToLower();
            List<sign> searchingList = mySigns.Where(i => i.meaning.ToLower().Contains(text)).ToList();
            UpdateList(searchingList);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                DialogResult result = MessageBox.Show("Save data before leave?", "You have not saved.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.Cancel))
                {
                    return;
                }
                else if (result.Equals(DialogResult.Yes))
                {
                    // Save
                    if (!ValidateFormInput())
                    {
                        return;
                    }
                    UpdateInfo();
                }
            }
            
            parent.Backward();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                button2.Text = "Save";
                txt_collectionId.ReadOnly = true;
                txt_collectionName.ReadOnly = false;
                txt_password.ReadOnly = false;

                txt_organisation.ReadOnly = false;
                txt_orgId.ReadOnly = true;
                txt_orgEmail.ReadOnly = false;
                txt_orgTel.ReadOnly = false;
                txt_address.ReadOnly = false;

                txt_contactPerson.ReadOnly = false;
                txt_contactPersonTitle.ReadOnly = false;
                txt_contactPersonEmail.ReadOnly = false;
                txt_contactPersonTel.ReadOnly = false;
                linklbl_orgDetails.Enabled = false;
            } else
            {
                // Save
                if (!ValidateFormInput())
                {
                    return;
                }
                UpdateInfo();

                button2.Text = "Edit";
                txt_collectionId.ReadOnly = true;
                txt_collectionName.ReadOnly = true;
                txt_password.ReadOnly = true;

                txt_organisation.ReadOnly = true;
                txt_orgId.ReadOnly = true;
                txt_orgEmail.ReadOnly = true;
                txt_orgTel.ReadOnly = true;
                txt_address.ReadOnly = true;

                txt_contactPerson.ReadOnly = true;
                txt_contactPersonTitle.ReadOnly = true;
                txt_contactPersonEmail.ReadOnly = true;
                txt_contactPersonTel.ReadOnly = true;
                linklbl_orgDetails.Enabled = true;
            }
            editMode = !editMode;
        }

        private bool ValidateFormInput()
        {
            bool validate = true;
            List<Control> requiredControls = new List<Control>();
            requiredControls.Add(txt_collectionName);
            requiredControls.Add(txt_password);
            requiredControls.Add(txt_organisation);
            requiredControls.Add(txt_orgEmail);
            requiredControls.Add(txt_orgTel);
            requiredControls.Add(txt_address);
            requiredControls.Add(txt_contactPerson);
            foreach (Control c in requiredControls)
            {
                if (c.Text == "")
                {
                    errorProvider.SetError(c, "Required.");
                    errorProvider.SetIconPadding(c, -20);
                    validate = false;
                }
                else
                {
                    errorProvider.SetError(c, "");
                }
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

        private void UpdateInfo()
        {
            signcollection sc = new signcollection
            {
                collectionId = mySignCollection.collectionId,
                password = txt_password.Text,
                name = txt_collectionName.Text,
                contactPerson = txt_contactPerson.Text,
                contactPersonEmail = txt_contactPersonEmail.Text,
                contactPersonTel = txt_contactPersonTel.Text,
                contactPersonTitle = txt_contactPersonTitle.Text
            };
            db.UpdateSignCollection(sc);

            organisation org = new organisation
            {
                id = myOrganisation.id,
                name = txt_organisation.Text,
                email = txt_orgEmail.Text,
                address = txt_address.Text,
                tel = txt_orgTel.Text
            };
            db.UpdateOrganisation(org);

            mySignCollection = db.GetSignCollection(mySignCollection.collectionId);
            mySigns = db.GetSigns(mySignCollection.collectionId);
            myOrganisation = db.GetOrganisation(mySignCollection.organisationId);
            this.SetForm();
        }

        private void linklbl_orgDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmOrganisationDetails frm = new FrmOrganisationDetails(parent, myOrganisation.id);
            parent.ForwardTo(frm);
        }

        private bool isVisible = false;
        private void FrmCollectionDetails_VisibleChanged(object sender, EventArgs e)
        {
            // if change for invisible to visible
            if (!isVisible && this.Visible && !editMode)
            {
                mySignCollection = db.GetSignCollection(mySignCollection.collectionId);
                mySigns = db.GetSigns(mySignCollection.collectionId);
                myOrganisation = db.GetOrganisation(mySignCollection.organisationId);
                textBox1.Text = "";
                SetForm();
            }

            isVisible = this.Visible;
        }
    }

}
