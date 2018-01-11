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
            personRuger.GrowOld();
            personRuger.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();

        }
    }
}
