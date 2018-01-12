using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Book
{
    class Book
    {
        //Kirjan tiedot
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public Book()
        {
            Title = "Legend of Skrt";
            Author = "Olli Jokinen";
            Id = 9965119;
            Price = 29.99;

        }
        public Book(string title, int id, string author, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;

        }
        //Methods

        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\n" +
                $"Kirjoittajan nimi: {Author}\n" +
                $"Id-numero: {Id}\n" +
                $"Kappalehinta: {Price}\n" +
                $"------------------------------------");

        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return ($"{this.Title} on kalliimpi kuin {book.Title} kirja\n");

            else
                return ($"{book.Title} on kalliimpi kuin {this.Title} kirja\n");



        }

    }
}
