﻿using System;
using System.Collections.Generic;
using System.Text;
using Bankdb.Models;
using Bankdb.Repositories;


namespace Bankdb.Repositories
{
    interface ICustomer
    {
        List<Bank> GetBanks();
        List<Bank> GetBankCustomers();
        List<Bank> GetBankAccounts();
        void Create(Customer customer);
        void Update(int id, Customer customer);
        void Delete(int id);

    }
}
