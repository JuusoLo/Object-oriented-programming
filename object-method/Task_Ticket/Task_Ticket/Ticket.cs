using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Ticket
{
    class Ticket
    {
        // Tiedot

        public int Age;
        public double Member;
        public double Soldier;
        public double Student;
        public double Price;

        //Constructor

        public Ticket()
        {
            Age = 0;
            Price = 16;
        }

        public Ticket(int age, double member, double soldier, double student, double price)
        {
            Age = age;
            Member = member;
            Soldier = soldier;
            Student = student;
            Price = price;

        }

        public void AskPersonInfo()
        {
            Console.WriteLine("Ohjelma laskee lipun hinnan.\n" +
                "---------------------");
            Console.Write($"Kerro ikäsi: ");
            string userInputAge = Console.ReadLine();
            Age = int.Parse(userInputAge);
            Console.Write($"Oletko MTK:n jäsen? Vastaa 1 = Kyllä tai 0 = Ei : ");
            string userInputMTK = Console.ReadLine();
            Member = double.Parse(userInputMTK);
            Console.Write($"Oletko varusmies? Vastaa 1 = Kyllä tai 0 = Ei : ");
            string userInputSoldier = Console.ReadLine();
            Soldier = double.Parse(userInputSoldier);
            Console.Write($"Opiskelija? Vastaa 1 = Kyllä tai 0 = Ei : ");
            string userInputStudent = Console.ReadLine();
            Student = double.Parse(userInputStudent);

        }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Ikäsi on: {Age}\n"+
                $"---------------------");
        }

        // Discount method



        public void Discount()
        {
            if (Age < 7)
                Console.WriteLine($"Lipun hinta on:{Price * 0}, pääset ilmaiseksi!");
            if (Age > 65)
                Console.WriteLine($"Lipun hinta on: {Price * 0.50}");
            if (Age > 7 && Age <= 15)
                Console.WriteLine($"Lipun hinta on: {Price * 0.50}");
            if (Age > 15 && Age < 65)
            {
                if (Soldier == 1)
                    Console.WriteLine($"Alennettu lipun hintasi on: {Price * 0.5} euroa");

                else
                {
                    if (Member == 1)
                    {
                        Price = Price * 0.85;
                    }
                    if (Student == 1)
                    {
                        Price = Price * 0.55;
                    }

                    Console.WriteLine($"Alennettu hintasi on {Price} euroa.");
                }
            }

        }




    }
}
