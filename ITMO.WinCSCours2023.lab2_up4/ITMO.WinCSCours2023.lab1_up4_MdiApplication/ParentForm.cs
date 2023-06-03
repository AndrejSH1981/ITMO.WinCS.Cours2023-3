using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCours2023.lab1_up4_MdiApplication
{
    public partial class ParentForm : Form
    {
        bool dataVis = false;
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
        }
        private void FileMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void MDIMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows is cascade";
        }
        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows is horizontal";
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
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
                    spWin.Text = "Windows is cascade";
                    break;

                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
        private void spWin_Click(object sender, EventArgs e)
        {
        
             spWin.Text = "Windows is horizontal";
        }
        private void spData_Click(object sender, EventArgs e)
        {
      
            spData.Text = Convert.ToString("Data");

            //  InitializeComponent();
            // Свойству Text панели spData устанавливается текущая дата


            //dataVis = true;
            if (dataVis == true)
            {
                spData.Text = Convert.ToString("Data");
                dataVis = false;

            }
            else
            {
                spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
                dataVis = true;

            }
        }
        private void ParentForm_Load(object sender, EventArgs e)
        {
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }
        private void WindowMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
