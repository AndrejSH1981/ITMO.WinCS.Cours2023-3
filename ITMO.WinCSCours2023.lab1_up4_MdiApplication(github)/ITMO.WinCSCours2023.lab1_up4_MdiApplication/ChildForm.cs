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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {

            InitializeComponent();
        }

        private void ToggleMenuItem_Click(object sender, EventArgs e)
        {

            if (ToggleMenuItem.Checked)
            {
                ToggleMenuItem.Checked = false;
                ParentForm.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ToggleMenuItem.Checked = true;
                ParentForm.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
