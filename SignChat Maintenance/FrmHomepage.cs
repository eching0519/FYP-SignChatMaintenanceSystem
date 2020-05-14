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
    public partial class FrmHomepage : Form
    {
        private String adminUsername;
        private PanelController panelController;

        public FrmHomepage(String username)
        {
            InitializeComponent();

            this.adminUsername = username;
            panelController = new PanelController(panel_content);
            FrmCollectionList frm = new FrmCollectionList(this);
            panelController.Reset(frm);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = this.Location;
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmCollectionList frm = new FrmCollectionList(this);
            panelController.Reset(frm);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmOrganisationList frm = new FrmOrganisationList(this);
            panelController.Reset(frm);
        }

        public void ForwardTo(Form frm)
        {
            panelController.Forward(frm);
        }

        public void Backward()
        {
            panelController.Backward();
        }

        public void ResetTo(Form frm)
        {
            panelController.Reset(frm);
        }

        public void ReplaceWith(Form frm)
        {
            panelController.Replace(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMyAccount frm = new FrmMyAccount(adminUsername);
            panelController.Reset(frm);
        }
    }
}
