using MyClass;
//using MyClass1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using Item = MyClass.Item;

namespace ITMO.WinCSCours2023.lab2.up6.BiblWorm
{

    public partial class Library : Form
    {
        List<Item> its = new List<Item>();
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1Nalichie.Checked; }
            set { checkBox1Nalichie.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox1Sort.Checked; }
            set { checkBox1Sort.Checked = value; }

        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox1Vozvrat.Checked; }
            set { checkBox1Vozvrat.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }


        //---------------------------------------------

        public string AuthorMag // том
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string TitleMag // Название
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string PublishHouseMag // Издательство
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public int PageMag // Количество страниц
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public int YearMag // Год издания
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public int InvNumberMag // Инвентарный номер
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public bool ExistenceMag // Подписка
        {
            get { return checkBox2NalichieMag.Checked; }
            set { checkBox2NalichieMag.Checked = value; }
        }
       /* public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox1Sort.Checked; }
            set { checkBox1Sort.Checked = value; }
        }*/
        public bool ReturnTimeMag // Возвращение в срок
        {
            get { return checkBox1VozvratMag.Checked; }
            set { checkBox1VozvratMag.Checked = value; }
        }
        public int PeriodUseMag // Инвентарный номер
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }


        public Library()
        {
            InitializeComponent();
        }

        private void button1Dobavit_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);

            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            
            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }





        private void button1DobavitMag_Click(object sender, EventArgs e)
        {
            Magazine b = new Magazine(AuthorMag, TitleMag, PublishHouseMag, PageMag, YearMag, InvNumberMag, ExistenceMag);  //String volume, string title1, int number, String title, int year, long invNumber, bool taken

            if (ReturnTimeMag)
                b.Return();
            b.PriceMagazine(PeriodUseMag);

            its.Add(b);

            AuthorMag = TitleMag = PublishHouseMag = "";
            PageMag = InvNumberMag = PeriodUseMag = 0;
            YearMag = 2000;
            ExistenceMag = ReturnTimeMag = false;
        }



        private void button1Posmotret_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());

            }
            richTextBox1.Text = sb.ToString();
        }


        private void Library_Load(object sender, EventArgs e)
        {

        }


    }


    }

