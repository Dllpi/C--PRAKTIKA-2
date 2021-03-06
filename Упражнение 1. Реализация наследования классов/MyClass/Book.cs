using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book : Item
    {
        private String author; // автор
        private String title; // название
        private String publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private static double price = 9;

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        new public void Show()
        {
            Console.WriteLine($"\nКнига:\n Автор: {author}\n Название: {title}\n Год издания: {year}\n Издательство: {publisher}\n {pages}стр.\nСтоимость аренды: {Book.price}");

            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }
    }
}
