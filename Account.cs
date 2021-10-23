using System;

namespace ATM
{
    public class Account
    {
        public int Balance { get; set; }
        public int OverDraft { get; set; }
        public int Total { get; set; }
        public int AccountNumber { get; set; }
        public int Pin { get; set; }

        public Account(string funds, string accountNumber, string overDraft, string pin)
        {
            Balance = int.Parse(funds);
            OverDraft = int.Parse(overDraft);
            AccountNumber = int.Parse(accountNumber);
            Pin = int.Parse(pin);
            Total = Balance + OverDraft;
        }

        public int Withdraw(int amount)
        {
            if (Total - amount > 0)
            {
                Balance -= amount;
                if (Balance < 0)
                {
                    OverDraft -= Math.Abs(Balance);
                    Balance = 0;
                }
            } 
            else
            {
                OverDraft -= amount;
            }

            return amount;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}