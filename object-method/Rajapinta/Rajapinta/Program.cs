using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rajapinta.Repositories;


namespace Rajapinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Einarin Elektroniikka\n");

            List<Tuote> tuotteet = new List<Tuote>();
            Tuote tuote1 = new Tuote("Konsoli", 400, 25);
            Tuote tuote2 = new Tuote("TV", 899, 30);
            Tuote tuote3 = new Tuote("Tuuletin", 199, 50);

            tuotteet.Add(tuote1);
            tuotteet.Add(tuote2);
            tuotteet.Add(tuote3);

            tuotteet[0].HaeTuote();
            tuotteet[0].LaskeYhteisArvo();
            tuotteet[1].HaeTuote();
            tuotteet[1].LaskeYhteisArvo();
            tuotteet[2].HaeTuote();
            tuotteet[2].LaskeYhteisArvo();

            List<Asiakas> asiakkaat = new List<Asiakas>();
            Asiakas asiakas1 = new Asiakas("Olli Jokinen", 6500);
            Asiakas asiakas2 = new Asiakas("Kalevi Karhu", 1299);
            Asiakas asiakas3 = new Asiakas("Seija Karvala", 599);

            asiakkaat.Add(asiakas1);
            asiakkaat.Add(asiakas2);
            asiakkaat.Add(asiakas3);

            asiakkaat[0].HaeAsiakas();
            asiakkaat[0].LaskeBonus();
            asiakkaat[1].HaeAsiakas(); 
            asiakkaat[1].LaskeBonus();
            asiakkaat[2].HaeAsiakas(); 
            asiakkaat[2].LaskeBonus();

            Kauppa kauppa = new Kauppa("Einarin Elektroniikka", "12 000 000");
            kauppa.LisaaAsiakas(asiakkaat);
            kauppa.LisaaTuote(tuotteet);
            kauppa.TulostaAsiakkaat();
            kauppa.TulostaTuotteet();
            Console.ReadKey();

        }
    }
}
