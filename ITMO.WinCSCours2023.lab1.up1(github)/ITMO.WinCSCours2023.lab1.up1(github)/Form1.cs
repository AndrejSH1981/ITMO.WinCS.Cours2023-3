using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCours2023.lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool re = false;


        private void button1_Click_1(object sender, EventArgs e)
        {
            //  this.FormBorderStyle = FormBorderStyle.Sizable;

            if (this.FormBorderStyle < FormBorderStyle.Sizable)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //this.Opacity = 1;


            if (this.Opacity == 1)
            {
                Opacity = 0.5;  //главное не ставить ниже 0,4 а то форма прозрачная слишком и её почти невидно
            }

            else
            {
                this.Opacity = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(300, 500);



            if (re == false)
            {
                this.Size = new Size(300, 500);
                re = true;
            }
            else
            {
                this.Size = new Size(820, 492);
                re = false;
            }


        }
    }
}
