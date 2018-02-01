using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hei tervetuloa! Autojen tiedot:");
            Vehicle newVehicle1 = new Vehicle("Farmari","BMW","2015",39990);
            newVehicle1.PrintCarInfo();

            Vehicle newVehicle2 = new Vehicle("Sedan", "Toyota", "2011", 9700);
            newVehicle2.PrintCarInfo();


            Console.ReadKey();
            
    
        }
    }
}
