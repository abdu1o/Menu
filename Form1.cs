using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem selectedMenuItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddMenu_Click(object sender, EventArgs e)
        {
            string topLevelMenuText = TopLevelMenu.Text;

            if (!string.IsNullOrEmpty(topLevelMenuText))
            {
                ToolStripMenuItem topLevelMenuItem = new ToolStripMenuItem(topLevelMenuText);
                topLevelMenuItem.Click += TopLevelMenuItem_Click;

                menuStrip1.Items.Add(topLevelMenuItem);
                selectedMenuItem = topLevelMenuItem;
            }
        }

        private void ButtonSubMenu_Click(object sender, EventArgs e)
        {
            string subItemText = SubItem.Text;

            if (selectedMenuItem != null)
            {
                if (!string.IsNullOrEmpty(subItemText))
                {
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem(subItemText);

                    selectedMenuItem.DropDownItems.Add(subMenuItem);
                }
            }
        }

        private void TopLevelMenuItem_Click(object sender, EventArgs e)
        {
            selectedMenuItem = (ToolStripMenuItem)sender;
        }
    }
}
