using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Vehicle uusiVehicle1 = new Vehicle("Farmari", "BMW", "2017", 70000);
            Car uusiAuto1 = new Car(2.0, "520", 5);

            Vehicle uusiVehicle2 = new Vehicle("Sedan", "Hyundai", "2012", 12000);
            Car uusiAuto2 = new Car(1.8, "Ultimate", 5);

            Console.WriteLine(uusiVehicle1.PrintInfo());
            Console.Write(uusiAuto1.ToString() + "\n");

            Console.WriteLine(uusiVehicle2.PrintInfo());
            Console.Write(uusiAuto2.ToString() + "\n");


            Console.WriteLine($"Onko BMW moottori isompi kuin Hyundain {uusiAuto1.Equals(uusiAuto2)}\n" +
                $"-----------------------------");

            Vehicle uusiVehicle3 = new Vehicle("Pakettiauto", "Mercedes", "2015", 60000);
            Console.WriteLine(uusiVehicle3.PrintInfo());
            KuormaAuto uusiKa = new KuormaAuto(3.0, "Mercedes", 2, 4000, 15);
            uusiKa.PrintInfo();

            Console.WriteLine(uusiKa.CalcCons());

            Console.ReadKey();
        }
    }
}