using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Class_Car
    {
        //Auton tiedot
        public string Brand;
        public int Speed;

        //Constructor
        public Class_Car()
        {
            Brand = null;
            Speed = 0;

        }

        //Methods

        public void AskData()
        {
            Console.WriteLine($"Tervetuloa! Kertoisitko meille informaatiota autostasi?");
            Console.WriteLine($"-------------------------\n" +
                $"Syötä auton merkki:\n");
            Brand = Console.ReadLine();
            Console.WriteLine($"-------------------------\n" +
                $"Syötä autosi nopeus:\n");
            Speed = int.Parse(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"-------------------------\n" +
                $"Auton merkki on: {Brand}\n" +
                $"Auton nopeus on: {Speed} km/h\n" +
                $"-------------------------\n");
        }

        public void Accelerate()
        {
            Console.WriteLine($"Anna kerroin jolla auton nopeuttasi lisätään:");
            float speed1 = float.Parse(Console.ReadLine());

            if (speed1 < 1)
                Console.WriteLine("Negatiivista muutosta ei sallita!");
            else
                Console.WriteLine($"Nopeutta lisättiin {speed1} kertaiseksi, uusi nopeutesi on: {speed1 * Speed} km/h\n" +
                    $"-------------------------");
        }

        public void Brake()
        {
            double speed2 = Speed * 0.9;

                Console.WriteLine($"Auton alkuperäistä nopeutta vähennettiin 10 %, uusi nopeutesi on: {speed2} km/h\n" +
                    $"-------------------------");

        }
    }
}
