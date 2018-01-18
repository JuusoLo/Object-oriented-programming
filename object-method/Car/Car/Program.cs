using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Class_Car newcar = new Class_Car();
            newcar.AskData();
            newcar.ShowCarInfo();
            newcar.Accelerate();
            newcar.Brake();


            Class_Car newcar2 = new Class_Car();
            newcar2.AskData();
            newcar2.ShowCarInfo();
            newcar2.Accelerate();
            newcar2.Brake();

            Class_Car newcar3 = new Class_Car();
            newcar3.AskData();
            newcar3.ShowCarInfo();
            newcar3.Accelerate();
            newcar3.Brake();

            Console.ReadKey();
        }
    }
}
