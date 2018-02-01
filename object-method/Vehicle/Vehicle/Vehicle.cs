using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        public string Type;
        public string Brand;
        public string Model;
        public double Price;


        //Constructor

        public Vehicle(string type, string brand, string model, double price)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Price = price;
        }

        public Vehicle()
        {
            Type = "Ei tiedossa";
            Brand = "Ei tiedossa";
            Model = "Ei tiedossa";
            Price = 0;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Auton malli: {Type}\n" +
                $"Merkki: {Brand}\n" +
                $"Vuosimalli: {Model}\n" +
                $"Hinta: {Price:c}\n" +
                $"---------------------------");
        }



        
    }
}
