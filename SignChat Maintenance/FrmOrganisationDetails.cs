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
    public partial class FrmOrganisationDetails : Form
    {
        private FrmHomepage parent;

        private SignChatDB db;
        private List<signcollection> signcollectionsList;
        private List<signcollection> currentList;

        organisation myOrganisation;
        bool editMode;

        private FrmOrganisationDetails(FrmHomepage parent)
        {
            InitializeComponent();

            this.parent = parent;
            db = new SignChatDB();
            editMode = false;
            txt_organisation.ReadOnly = true;
            txt_orgEmail.ReadOnly = true;
            txt_address.ReadOnly = true;
            txt_orgTel.ReadOnly = true;
            txt_orgId.ReadOnly = true;
        }

        public FrmOrganisationDetails(FrmHomepage parent, int organisationId):this(parent)
        {
            myOrganisation = db.GetOrganisation(organisationId);
            signcollectionsList = db.GetCollectionList(organisationId);
            SetData();
        }

        public FrmOrganisationDetails(FrmHomepage parent, organisation org) : this(parent)
        {
            myOrganisation = org;
            signcollectionsList = db.GetCollectionList(org.id);
            SetData();
        }

        public void SetData()
        {
            txt_organisation.Text = myOrganisation.name;
            txt_orgId.Text = myOrganisation.id.ToString();
            txt_orgEmail.Text = myOrganisation.email;
            txt_orgTel.Text = myOrganisation.tel;
            txt_address.Text = myOrganisation.address;
            UpdateList(signcollectionsList);
        }

        public void UpdateList(List<signcollection> newList)
        {
            dgv_collection.Rows.Clear();
            
            foreach(signcollection c in newList)
            {
                int signNum = db.GetNoOfSign(c.collectionId);
                int datasetNum = db.GetNoOfDataset(c.collectionId);
                dgv_collection.Rows.Add(c.collectionId, c.name, signNum, datasetNum, c.contactPerson);
            }

            currentList = newList;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text.ToLower();
            List<signcollection> searchingList = signcollectionsList.Where(i => i.collectionId.ToString().ToLower().Contains(text) || 
                                                                              i.name.ToLower().Contains(text) || 
                                                                              i.contactPerson.ToLower().Contains(text)).ToList();
            this.UpdateList(searchingList);
        }

        private void Dgv_collection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            String collectionId = currentList.ElementAt(e.RowIndex).collectionId;
            
            FrmCollectionDetails frm = new FrmCollectionDetails(parent, collectionId);
            parent.ForwardTo(frm);
        }

        private void button1_Click(object sender, EventArgs e)
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
                    this.UpdateDatabase();
                }
            }

            parent.Backward();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNewCollection frm = new FrmNewCollection(parent, myOrganisation.id);
            parent.ForwardTo(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(editMode)
            {
                if(!ValidateFormInput())
                {
                    return;
                }
                this.UpdateDatabase();

                txt_organisation.ReadOnly = true;
                txt_orgEmail.ReadOnly = true;
                txt_address.ReadOnly = true;
                txt_orgTel.ReadOnly = true;
                button2.Text = "Edit";
            } else
            {
                txt_organisation.ReadOnly = false;
                txt_orgEmail.ReadOnly = false;
                txt_address.ReadOnly = false;
                txt_orgTel.ReadOnly = false;
                button2.Text = "Save";
            }
            editMode = !editMode;
        }

        private bool ValidateFormInput()
        {
            bool isValid = true;

            List<Control> controls = new List<Control>();
            controls.Add(txt_organisation);
            controls.Add(txt_orgEmail);
            controls.Add(txt_orgTel);
            controls.Add(txt_address);
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

            return isValid;
        }

        private void UpdateDatabase()
        {
            organisation org = new organisation
            {
                id = myOrganisation.id,
                name = txt_organisation.Text,
                email = txt_orgEmail.Text,
                tel = txt_orgTel.Text,
                address = txt_address.Text
            };
            db.UpdateOrganisation(org);
        }



        private bool isVisible = false;
        private void FrmOrganisationDetails_VisibleChanged(object sender, EventArgs e)
        {
            // if change for invisible to visible
            if (!isVisible && this.Visible)
            {
                myOrganisation = db.GetOrganisation(myOrganisation.id);
                signcollectionsList = db.GetCollectionList(myOrganisation.id);

                txt_organisation.Text = myOrganisation.name;
                txt_orgId.Text = myOrganisation.id.ToString();
                txt_orgEmail.Text = myOrganisation.email;
                txt_orgTel.Text = myOrganisation.tel;
                txt_address.Text = myOrganisation.address;

                List<signcollection> temp = signcollectionsList;
                foreach (DataGridViewRow row in dgv_collection.Rows)
                {
                    signcollection sc = temp.FirstOrDefault(i => i.collectionId == row.Cells[0].Value.ToString());
                    if (sc == null)
                    {
                        dgv_collection.Rows.Remove(row);
                        continue;
                    }
                    int signNum = db.GetNoOfSign(sc.collectionId);
                    int datasetNum = db.GetNoOfDataset(sc.collectionId);

                    row.Cells[1].Value = sc.name;
                    row.Cells[2].Value = signNum;
                    row.Cells[3].Value = datasetNum;
                    row.Cells[4].Value = sc.contactPerson;
                    temp.Remove(sc);
                }

                if (temp.Count > 0)
                {
                    foreach (signcollection sc in temp)
                    {
                        organisation o = db.GetOrganisation(sc.organisationId);
                        int signNum = db.GetNoOfSign(sc.collectionId);
                        int datasetNum = db.GetNoOfDataset(sc.collectionId);

                        dgv_collection.Rows.Add(sc.collectionId, sc.name, signNum, datasetNum, sc.contactPerson);
                    }
                }
            }

            isVisible = this.Visible;
        }
    }
}
