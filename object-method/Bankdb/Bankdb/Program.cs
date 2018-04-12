using System;
using Bankdb.Repositories;
using System.Linq;
using Bankdb.Models;

namespace Bankdb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tervetuloa");
            //BankRepository bankRepository = new BankRepository();
            //Bank bank = new Bank();
            //bank.Name = "Nordea";
            //bank.Bic = "ITELFIHH";
            //bankRepository.Delete(5);
            //CustomerRepository customerRepository = new CustomerRepository();
            //Customer customer = new Customer();
            //customer.Firstname = "Jorma";
            //customer.Lastname = "Uotinen";
            //customer.BankId = 3;
            //customerRepository.Create(customer);
            //CustomerRepository accountrepository = new CustomerRepository();
            //Account account = new Account();
            //account.Iban = "FI271827364829182736";
            //account.Name = "Jorma Uotinen";
            //account.BankId = 3;
            //account.CustomerId = 4;
            //account.Balance = 47020;
            //accountrepository.Create(account);
            AccountRepository accountRepository = new AccountRepository();
            Transaction transaction = new Transaction
            {
                Iban = "FI257638291827364758",
                Amount = -19273,
                TimeStamp = DateTime.Today
            };
            accountRepository.AddTransaction(transaction);
            Console.WriteLine("Morjes");

            Console.ReadLine();



        }
    }
}
