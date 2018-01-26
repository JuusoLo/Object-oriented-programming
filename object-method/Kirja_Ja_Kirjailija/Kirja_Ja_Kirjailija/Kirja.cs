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
        private double uusiHinta;
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
            UusiHinta = Hinta;
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
        // Method
        public void HaeKija(Kirja kirja)
        {
            if (this.Nimi.Equals(kirja.Nimi))
                Console.WriteLine("Kirja löytyi!");

            else
            {
                Console.WriteLine($"Kirjaa:{kirja.Nimi}, ei löytynyt");

            }
            Console.WriteLine($"{kirja.Nimi}\n" +
                    $"{kirja.Kirjailija}\n" +
                    $"{kirja.Kustantaja}\n" +
                    $"{kirja.Hinta:C}\n" +
                    $"{kirja.Teema}\n");
            if (kirja.Hinta > 30)
                Console.WriteLine($"Alennettu hinta on: {kirja.UusiHinta:C}\n");
            Console.WriteLine($"---------------------------");
        }
        // Kirjan tiedot
        public void HaeKija(string nimi)
        {
            if (Nimi.Equals(nimi))
                TulostaKirja();
            else
            {
                Console.WriteLine($"Kirjaa:{Nimi}, ei löytynyt");
                TulostaKirja();
            }
        }
        public void TulostaKirja()
        {
            Console.WriteLine($"{Nimi}\n" +
                   $"{Kirjailija}\n" +
                   $"{Kustantaja}\n" +
                   $"{Hinta}\n" +
                   $"{Teema}\n" +
                   $"---------------------------");
        }
        //Kirjan uusi hinta
        public double UusiHinta
        {
            get
            {
                return uusiHinta;
            }
            set
            {
                if (value > 30)
                {
                    uusiHinta = value * 0.9;
                    //Console.WriteLine($"Uusi hinta on: {Hinta}");
                    //Console.WriteLine($"Kirjan {Nimi} hinta oli: {Hinta}, uusi hinta on : {uusiHinta}€");
                }

            }
        }


        public static void TeemanVaihto()
        {
            Console.WriteLine(VaihdaTeema);
        }
    }
}
