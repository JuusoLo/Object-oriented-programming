using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Firma
{
    class Firma
    {
        // Yrityksen tiedot
        public string Title;
        public string Address;
        public string Phone;
        public double Outcome;
        public double Expense;

        // Constructor
        public Firma(string title, string address, string phone, double outcome, double expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }
        // Constructor määrittämättä
        public Firma()
        {
            Title = " Ei tiedossa";
            Address = "Ei tiedossa";
            Phone = "Ei tiedossa";
            Outcome = 0;
            Expense = 0;
        }
        //kopiomuodostin
         public Firma(Firma company)
        {
            Title = company.Title;
            Address = company.Address;
            Phone = company.Phone;
            Outcome = company.Outcome;
            Expense = company.Expense;
        }

        //Method

        public void AskData()
        {
            Console.WriteLine($"-----------------------\n" +
                $"Syötä yrityksesi tiedot nimi:");
            Title = Console.ReadLine();
            Console.WriteLine($"-----------------------\n" +
                $"Osoite: ");
            Address = Console.ReadLine();
            Console.WriteLine($"-----------------------\n" +
                $"Puhelinnumero: ");
            Phone = Console.ReadLine();
            Console.WriteLine($"-----------------------\n" +
                $"Tulot: ");
            Outcome = double.Parse(Console.ReadLine());
            Console.WriteLine($"-----------------------\n" +
                $"Menot: ");
            Expense = double.Parse(Console.ReadLine());
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"-----------------------\n" +
                $"Yritksen nimi on: {Title}\n" +
                $"Osoite: {Address}\n" +
                $"Puhelinnumero: {Phone}\n" +
                $"Tulot: {Outcome}\n" +
                $"Menot: {Expense}\n" +
                $"-----------------------");
        }
        
        // Method firmat voittoprosentti

        public void CompanyProfitCalculate()
        {
            double profit = (Outcome - Expense) / Expense * 100;

            Console.WriteLine($"Yrityksesi voittoprosentti on : {profit:f0}%");

            if (profit < 100)
            {
                Console.WriteLine("Yrityksesi tulos on kehno");
            }
            if (profit <= 300)
            {
                Console.WriteLine("Yrityksesi tulos on tyydyttävä");
            }
            if (profit > 300)
            {
                Console.WriteLine("Yrityksesi tulos on hyvä");
            }


        }



    

    }
}
