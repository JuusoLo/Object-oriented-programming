using System;
using Kirja_Kirjailija;
using System.Collections.Generic;
using System.Text;

namespace Kirja_Kirjailija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Kirja newBook = new Kirja();
            Kirja newBook2 = new Kirja();
            newBook.AskData();
            Console.ReadLine();
            newBook.Print();
            newBook.SearchBook();
            Console.ReadLine();
            newBook2.AskData();
            newBook2.Print();
            newBook2.SearchBook();
            Console.ReadLine();

            Console.ReadKey();
            

        }
    }
}
