using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person personRuger = new Person();
            personRuger.Name = "Ruger";
            Console.WriteLine($"Ruger ikä: {personRuger.GetAge()}");

            personRuger.GrowOld();
            Console.WriteLine($"Ruger ikä: {personRuger.GetAge()}");
            personRuger.GrowOld(50);
            personRuger.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();

        }
    }
}
