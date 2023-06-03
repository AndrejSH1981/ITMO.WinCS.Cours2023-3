using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCours2023.lab1_up5
{
    public partial class Form2 : Form
    {
        private int openDocuments = 0;
        public Form2()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.Form1_Load(sender, e);
            Form1 newChild = new Form1();
            newChild.Form1_Load(sender, e);
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
