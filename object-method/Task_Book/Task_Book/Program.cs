using System;

namespace Task_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book newBook = new Book("Legend of Skrt", 9965119,"Olli Jokinen", 29.99);
            newBook.PrintBookInfo();

            Book newBook2 = new Book("Karhukopla", 88487716, "Urho Kakkonen", 39.99);
            newBook2.PrintBookInfo();

            Book newBook3 = new Book("Ralli Mikko", 88998727, "Migis Turbbis", 19.99);
            newBook3.PrintBookInfo();

            Console.WriteLine($"{newBook2.CompareBook(newBook)}");
            Console.WriteLine($"{newBook3.CompareBook(newBook)}");



            Console.ReadKey();
        }
    }
}
