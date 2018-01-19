using System;

namespace Task_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Ticket newticket = new Ticket();
            newticket.AskPersonInfo();
            newticket.ShowPersonInfo();
            newticket.Discount();

            Console.ReadKey();


        }
    }
}
