using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Transaction
    {
        private double _sum;
        public DateTime _timeStamp;

        public double Sum { get => _sum; set => _sum = value; }

        public Transaction(double sum, DateTime timeStamp)
        {
            _sum = sum;
            _timeStamp = timeStamp;
        }
    }
}
