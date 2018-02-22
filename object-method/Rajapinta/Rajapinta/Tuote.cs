using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinta
{
    class Tuote : ITuote
    {
        public string Name;
        public double Price;
        public double Count;

        public Tuote(string name, double price, double count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public override string ToString()
        {
            return ($"Tuotteen nimi: {Name}\n" +
                     $"Hinta: {Price}\n" +
                     $"Lukumäärä: {Count}\n" +
                     $"--------------------------");
        }

        public void HaeTuote()
        {
            Console.WriteLine($"Tuotteen nimi: {Name}\n" +
                     $"Hinta: {Price}\n" +
                     $"Lukumäärä: {Count}\n" +
                     $"--------------------------");
        }
        public void LaskeBonus()
        {

        }
    }
}
