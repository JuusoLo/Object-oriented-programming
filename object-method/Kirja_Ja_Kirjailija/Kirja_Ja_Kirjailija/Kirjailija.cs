using System;
using System.Collections.Generic;
using System.Text;
using Kirjallisuus;

namespace Kirja_Ja_Kirjailija
{
    class Kirjailija
    {
        public string Nimi;
        public string Syntymapaiva;
        public string Kirja;

        public Kirjailija(string nimi, string syntymapaiva, string kirja)
        {
            Nimi = nimi;
            Syntymapaiva = syntymapaiva;
            Kirja = kirja;
        }

        public void TulostaKirjailijanTiedot()
        {
            Console.WriteLine($"Kirjailijan nimi on : {Nimi}\n" +
                $"Syntymäpäivä: {Syntymapaiva}\n" +
                $"Kirja: {Kirja}\n" +
                $"---------------------------");
        }
    }
}
