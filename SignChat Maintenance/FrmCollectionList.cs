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
    public partial class FrmCollectionList : Form
    {
        private FrmHomepage parent;

        private SignChatDB db;
        private List<signcollection> signcollectionsList;

        private List<signcollection> currentList;

        public FrmCollectionList(FrmHomepage parent)
        {
            InitializeComponent();

            this.parent = parent;

            db = new SignChatDB();
            signcollectionsList = db.GetCollectionList();
            UpdateList(signcollectionsList);
        }

        public void UpdateList(List<signcollection> newList)
        {
            dgv_collection.Rows.Clear();
            
            foreach(signcollection c in newList)
            {
                int signNum = db.GetNoOfSign(c.collectionId);
                int datasetNum = db.GetNoOfDataset(c.collectionId);
                dgv_collection.Rows.Add(c.collectionId, c.name, c.organisation.name, signNum, datasetNum);
            }

            currentList = newList;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text.ToLower();
            List<signcollection> searchingList = signcollectionsList.Where(i => i.collectionId.ToString().ToLower().Contains(text) || 
                                                                              i.name.ToLower().Contains(text) || 
                                                                              i.organisation.name.ToLower().Contains(text)).ToList();
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
            FrmNewCollection frm = new FrmNewCollection(parent);
            parent.ForwardTo(frm);
        }

        private bool isVisible = false;
        private void FrmCollectionList_VisibleChanged(object sender, EventArgs e)
        {
            // if change for invisible to visible
            if (!isVisible && this.Visible) 
            {
                signcollectionsList = db.GetCollectionList();
                List<signcollection> temp = signcollectionsList;
                foreach(DataGridViewRow row in dgv_collection.Rows)
                {
                    signcollection sc = temp.FirstOrDefault(i => i.collectionId == row.Cells[0].Value.ToString());
                    if (sc == null) 
                    {
                        dgv_collection.Rows.Remove(row);
                        continue;
                    }
                    organisation o = db.GetOrganisation(sc.organisationId);
                    int signNum = db.GetNoOfSign(sc.collectionId);
                    int datasetNum = db.GetNoOfDataset(sc.collectionId);

                    row.Cells[1].Value = sc.name;
                    row.Cells[2].Value = o.name;
                    row.Cells[3].Value = signNum;
                    row.Cells[4].Value = datasetNum;
                    temp.Remove(sc);
                }

                if (temp.Count > 0) 
                {
                    foreach(signcollection sc in temp)
                    {
                        organisation o = db.GetOrganisation(sc.organisationId);
                        int signNum = db.GetNoOfSign(sc.collectionId);
                        int datasetNum = db.GetNoOfDataset(sc.collectionId);

                        dgv_collection.Rows.Add(sc.collectionId, sc.name, o.name, signNum, datasetNum);
                    }
                }
            }

            isVisible = this.Visible;
        }
    }
}
