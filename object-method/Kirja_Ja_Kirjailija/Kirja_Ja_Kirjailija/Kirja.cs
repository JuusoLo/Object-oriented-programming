using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_Ja_Kirjailija
{
    class Kirja
    {
        public string Nimi;
        public string Kirjailija;
        public string Kustantaja;
        public double Hinta;
        public string Teema;

        static string VaihdaTeema;


        //Constructor
        public Kirja()
        {
            Nimi = "Ei tiedossa!";
            Kirjailija = "Ei tiedossa!";
            Kustantaja = "Ei Tiedossa!";
            Hinta = 0;
            Teema = "Ei Tiedossa";

        }

        public Kirja(string Nimi, string Kirjailija, string Kustantaja, double Hinta, string Teema)
        {
            this.Nimi = Nimi;
            this.Kirjailija = Kirjailija;
            this.Kustantaja = Kustantaja;
            this.Hinta = Hinta;
            this.Teema = Teema;
        }
        //Toinen kirja
        public Kirja(Kirja kirja)
        {
            this.Nimi = kirja.Nimi;
            this.Kirjailija = kirja.Kirjailija;
            this.Kustantaja = kirja.Kustantaja;
            this.Hinta = kirja.Hinta;
            this.Teema = kirja.Teema;
        }
        public void HaeKija(Kirja kirja)
        {
            if (this.Nimi.Equals(kirja.Nimi))
                Console.WriteLine($"{kirja.Nimi}\n" +
                    $"{kirja.Kirjailija}\n" +
                    $"{kirja.Kustantaja}\n" +
                    $"{kirja.Hinta}\n" +
                    $"{kirja.Teema}\n" +
                    $"---------------------------");
            else
                Console.WriteLine($"Kirjaa:{kirja.Nimi}, ei löytynyt");
        }

        public static void TeemanVaihto()
        {
            Console.WriteLine(VaihdaTeema);
        }
    }
}
