using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Book : Item
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;

        private double cust;
        private bool returnSrok;

        private static double price = 9;
        
        static Book()       //статический конструктор
        {
            price = 100;
        }

        
        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base (invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        { }



        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override string ToString()
        {
            if (this.IsAvailable())
            return "\nКнига:\n Автор: " + author +"\n Название: " + title +
            "\n Год издания: " + year + "., " + pages + " стр. \n Стоимость аренды: " + Book.price + " p.\n" + base.ToString()
            + "\nИтого за чтение: " + cust + " p.";
            else
                return "\nКнига:\n Автор: " + author +"\n Название: " + title +
            "\n Год издания: " + year + "., " + pages + " стр. \n Стоимость аренды: " + Book.price + " p.\n" + base.ToString();

        }

        public void PriceBook(int s)
        {

            if (this.returnSrok == true)
                this.cust = s * price;
            else this.cust = s * (price + price * 0.13); ;
            
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

    }
}
