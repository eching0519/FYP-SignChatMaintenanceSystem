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
    public partial class FrmOrganisationList : Form
    {
        private FrmHomepage parent;

        private List<organisation> organisationList;
        private List<organisation> currentList;
        SignChatDB db;

        public FrmOrganisationList(FrmHomepage parent)
        {
            InitializeComponent();

            this.parent = parent;

            db = new SignChatDB();
            organisationList = db.GetOrganisationList();
            UpdateList(organisationList);
        }

        public void UpdateList(List<organisation> newList)
        {
            currentList = newList;
            dgv_organisation.Rows.Clear();
            
            foreach(organisation o in newList)
            {
                dgv_organisation.Rows.Add(o.id, o.name, o.email, o.tel, o.address);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text.ToLower();
            List<organisation> searchingList = organisationList.Where(i => i.id.ToString().ToLower().Contains(text) || 
                                                                           i.name.ToLower().Contains(text) || 
                                                                           i.email.ToLower().Contains(text) || 
                                                                           i.tel.ToLower().Contains(text) || 
                                                                           i.address.ToLower().Contains(text)).ToList();
            this.UpdateList(searchingList);
        }

        private void dgv_organisation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            organisation org = currentList.ElementAt(e.RowIndex);
            FrmOrganisationDetails frm = new FrmOrganisationDetails(parent, org);
            parent.ForwardTo(frm);
        }

        private bool isVisible = false;
        private void FrmOrganisationList_VisibleChanged(object sender, EventArgs e)
        {
            // if change for invisible to visible
            if (!isVisible && this.Visible)
            {
                organisationList = db.GetOrganisationList();
                List<organisation> temp = organisationList;
                foreach (DataGridViewRow row in dgv_organisation.Rows)
                {
                    organisation o = temp.FirstOrDefault(i => i.id == Convert.ToInt32(row.Cells[0].Value));
                    if (o == null)
                    {
                        dgv_organisation.Rows.Remove(row);
                        continue;
                    }
                    row.Cells[1].Value = o.name;
                    row.Cells[2].Value = o.email;
                    row.Cells[3].Value = o.tel;
                    row.Cells[4].Value = o.address;
                    temp.Remove(o);
                }

                if (temp.Count > 0)
                {
                    foreach (organisation o in temp)
                    {
                        dgv_organisation.Rows.Add(o.id, o.name, o.email, o.tel, o.address);
                    }
                }
            }

            isVisible = this.Visible;
        }
    }
}
