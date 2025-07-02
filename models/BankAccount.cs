using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation_RealLifeExmpls.models
{
    public class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }
        public BankAccount(decimal InitialBalance)
        {
            if (InitialBalance < 0) throw new InvalidDataException("Initial Balance Can not be Negative!");
            balance = InitialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new InvalidDataException("Deposit Amount must be positive!");
            balance += amount;
        }
        public void WidthDraw(decimal amount)
        {
            if (amount <= 0) throw new InvalidDataException("Widthdrawal amount Can not be Negative!");
            if (balance > amount)
            {
                balance -= amount;
            }
            else throw new InvalidOperationException("Widthdraw amount must be below current balance. Check Current Balance.");
        }
    }
}