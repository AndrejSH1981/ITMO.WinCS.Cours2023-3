using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCours2023.lab2.up7.RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(36, 16);
                lbl.Size = new System.Drawing.Size(32, 23);

                lbl.Name = "label1l";
                lbl.TabIndex = 1;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(66, 16);
                txt.Size = new System.Drawing.Size(194, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 2;
                txt.Text = "";
                groupBox1.Controls.Add(txt);




                Label lb2 = new Label();
                lb2.Location = new System.Drawing.Point(66, 86);
                lb2.Size = new System.Drawing.Size(32, 23);

                lb2.Name = "label22";
                lb2.TabIndex = 3;
                lb2.Text = "PIN3";
                groupBox1.Controls.Add(lb2);

                TextBox txt2 = new TextBox();
                txt2.Location = new System.Drawing.Point(86, 86); //   Не понял как начать заполнение текстбокс не из-за угла
                txt2.Size = new System.Drawing.Size(194, 20);
                txt2.Name = "textboxx1";
                txt2.TabIndex = 4;
                txt2.Text = "";
                groupBox1.Controls.Add(txt2);

                txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 1 )
                {
                    groupBox1.Controls.Clear(); // Почему то работает хоршо только полная очистка !!!!!!!!!!!
                    lcv -= 1;
                }




               /* int Pcv;
                Pcv = groupBox1.Controls.Count;// определяется количество элементов
                while (Pcv > 1)

                {
                    groupBox1.Controls.RemoveAt(Pcv - 1);

                    Pcv -= 1;
                }*/





            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               
                MessageBox.Show("Поле Name не может содержать цифры");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }
    }
}


