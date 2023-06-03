using MyClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        private double custMag;
        private bool returnSrokMag;
        private static double priceMag = 19;

        static Magazine()       //статический конструктор
        {
            priceMag = 1000;
        }

        
        public Magazine(String volume, string title1, String title, int number,  int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;

        }

        public bool IfSubs { get; set; } // подписка на журнал
                                         // String author, String title, String publisher, int pages, int year, long invNumber, bool taken,,, string title1,
   
   
        public Magazine()
    { }



    public void PriceMagazine(int s)
        {

            if (this.returnSrokMag == true)
                this.custMag = s * priceMag;
            else this.custMag = s * (priceMag + priceMag * 0.13); ;

        }

        public void ReturnSrokMag()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }
        public static void SetPriceMag(double priceMag)
        {
            Magazine.priceMag = priceMag;
        }

        public override string ToString()
       {
           if (taken)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
       }

        public override void Return()    // операция "вернуть"
        {
            if (returnSrokMag == true)
                taken = true;
            else
                taken = false;
        }

        /*public override void Return()
        {
            throw new NotImplementedException();
        }*/
    }
}
