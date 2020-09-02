﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public void Deposit(double amount)
        {
            balance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is {balance}");
        }
    }
}
