using System;
using System.Collections.Generic;
using Bankdb.Models;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Bankdb.Repositories
{
    class AccountRepository
    {
        private readonly BankdbContext _context = new BankdbContext();

        public List<Account> Read()
        {
            List<Account> accounts = _context.Account.ToListAsync().Result;
            return accounts;
        }

        public Account GetAccountByIban(string iban)
        {
            var account = _context.Account.FirstOrDefault(a => a.Iban == iban);
            return account;
        }


        public void CreateAccount(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(string iban)
        {
            var delAccount = _context.Account.FirstOrDefault(a => a.Iban == iban);
            if (delAccount != null)
                _context.Account.Remove(delAccount);
            _context.SaveChanges();
        }
       public void AddTransaction(Transaction transaction)
        {
            using (var context = new BankdbContext())
            {
                try
                {
                    //Lisätään tapahtumiin rivi
                    context.Add(transaction);
                    //Etsitään oikea tili
                    var account = GetAccountByIban(transaction.Iban);
                    decimal balanceBeforeTransaction = account.Balance;
                    //Lasketaan uusi saldo
                    account.Balance += transaction.Amount;
                    //Update account table
                    context.Account.Update(account);
                    //Tallennetaan muutokset
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
  }
