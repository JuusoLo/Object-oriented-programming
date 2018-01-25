using System;

namespace Kirja_Ja_Kirjailija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Kirja uusiKirja1 = new Kirja("Johtajan yliote", "Olli Jokinen", "Alpha Oy", 39.90, "Elämänkerta");
            uusiKirja1.HaeKija(uusiKirja1);
            Kirja.TeemanVaihto();
            Kirja uusiKirja2 = new Kirja("Grili maisteri", "Timo Jutila", "Lidl", 12.90, "Ruokakirja");
            uusiKirja2.HaeKija(uusiKirja1);
            Kirja uusiKirja3 = new Kirja("Las Palmas", "Miguel Logniness", "Travel Boys", 27.95, "Matkailu");
            uusiKirja1.HaeKija(uusiKirja3);
            Kirja.TeemanVaihto();
            Console.ReadKey();
        }
    }
}
