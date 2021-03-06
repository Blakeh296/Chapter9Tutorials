﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSimulator
{
    class BankAccount
    {
        // Field
        private decimal _balance;

        // Constructor
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        // Balance property (read-only)
        public decimal Balance
        {
            get { return _balance; }
        }

        // Deposit method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        // Widthdrawl method
        public void Withdraw (decimal amount)
        {
            _balance -= amount;
        }
    }
}
