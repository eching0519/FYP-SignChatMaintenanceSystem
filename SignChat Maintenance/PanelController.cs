using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignChat_Maintenance
{
    class PanelController
    {
        private Panel panel;
        private Stack<Form> pages;

        public PanelController(Panel panel)
        {
            this.panel = panel;
            pages = new Stack<Form>();
        }

        public void Forward(Form form)
        {
            pages.Push(form);

            Form topPage = pages.Peek();
            panel.Controls.Clear();
            topPage.TopLevel = false;
            topPage.TopMost = true;
            topPage.AutoScroll = true;
            topPage.Dock = DockStyle.Fill;
            panel.Controls.Add(topPage);
            topPage.Show();
        }

        public void Backward()
        {
            pages.Pop();

            Form topPage = pages.Peek();
            panel.Controls.Clear();
            topPage.TopLevel = false;
            topPage.TopMost = true;
            topPage.AutoScroll = true;
            topPage.Dock = DockStyle.Fill;
            panel.Controls.Add(topPage);
            topPage.Show();
        }

        public void Reset(Form form)
        {
            pages.Clear();
            this.Forward(form);
        }

        public void Replace(Form form)
        {
            pages.Pop();
            this.Forward(form);
        }
    }
}
