using System;
using Kirjallisuus;

namespace Kirja_Ja_Kirjailija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hei tervetuloa! Saat 10% alennuksen jos kirjan hinta on yli 30€\n");

            Kirjailija uusiKirjailija1 = new Kirjailija("Olli Jokinen", "27.04.1978", "Johtajan yliote");
            uusiKirjailija1.TulostaKirjailijanTiedot();
            Kirja uusiKirja1 = new Kirja("Johtajan yliote", "Olli Jokinen", "Alpha Oy", 39.90, "Elämänkerta");
            Console.WriteLine($"Tässä kirjailija tulostettuna ominaisuudella : {uusiKirja1.Kirjailija}");
            uusiKirja1.HaeKija(uusiKirja1);
            Kirja.TeemanVaihto();

            Kirjailija uusiKirjailija2 = new Kirjailija("Timo Jutila", "31.12.1967", "Grillimaisteri");
            uusiKirjailija2.TulostaKirjailijanTiedot();
            Kirja uusiKirja2 = new Kirja("Grilli maisteri", "Timo Jutila", "Lidl", 12.90, "Ruokakirja");
            uusiKirja1.HaeKija(uusiKirja2);

            Kirjailija uusiKirjailija3 = new Kirjailija("Miguel Logniness", "12.06.1987", "Las Palmas");
            uusiKirjailija3.TulostaKirjailijanTiedot();
            Kirja uusiKirja3 = new Kirja("Las Palmas", "Miguel Logniness", "Travel Boys", 30.15, "Matkailu");
            uusiKirja1.HaeKija(uusiKirja3);

            Console.ReadKey();
        }
    }
}
