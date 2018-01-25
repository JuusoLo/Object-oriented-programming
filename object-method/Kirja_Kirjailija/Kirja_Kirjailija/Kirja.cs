using System;
using Kirja_Kirjailija;
using System.Collections.Generic;
using System.Text;


namespace Kirja_Kirjailija
{
    class Kirja
    {
        public string Name;
        public string Writer;
        public string Publisher;
        public double Price;
        public string Theme;

        static string ThemeName;

        //Constructor

        public Kirja(string Name, string Writer, string Publisher, double Price, string Theme)
        {
            this.Name = Name;
            this.Writer = Writer;
            this.Publisher = Publisher;
            this.Price = Price;
            this.Theme = Theme;
        }

        public void AskData()
        {
            Console.WriteLine("Tervetuloa!");
            Console.WriteLine($"Syötä hakemasi kirjan tiedot\n" +
                $"Nimi: {Name}\n," +
                $"Kirjailija: {Writer}\n" +
                $"Julkaisija: {Publisher}\n" +
                $"------------------------------------");
        }

        //Method

        public void Print()
        {
            Console.WriteLine($"{Name}\n {Writer}\n {Publisher}\n {Price}\n {Theme}\n" +
                $"------------------------------------\n");
        }

        public void SearchBook()
        {
            if (this.Name.Equals(Name))
            {
                Console.WriteLine($"{Name}\n {Writer}\n {Publisher}\n {Price}\n {Theme}\n" +
                    $"------------------------------------\n");
            }
            else
                Console.WriteLine("Haettua kirjaa ei löytynyt");
        }

        public static void VaihdaTeema(Kirja newBook2, string Theme)
        {
            Theme = ThemeName;
        }
    }
}
