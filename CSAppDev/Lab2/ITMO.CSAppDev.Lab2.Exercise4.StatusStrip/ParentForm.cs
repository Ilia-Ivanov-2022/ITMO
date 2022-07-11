using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSAppDev.Lab1.Exercise4.MdiApp
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            // spData panel property Text is being set to current date
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows are caascade";
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows are horizontal";
        }

        private void MdiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void NewMenuItem_Click(object sender, EventArgs e)
        //{
        //    ChildForm newChild = new ChildForm();
        //    newChild.MdiParent = this;
        //    newChild.Show();
        //    newChild.Text = newChild.Text + " " + ++openDocuments;
        //}
        //private int openDocuments = 0;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Tile":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows are cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows are horizontal";
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
