using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        public int TotalCash { get; set; }

        public List<Account> Accounts { get; set; }

        public ATM(string amount)
        {
            TotalCash = int.Parse(amount);
        }

        public void Withdraw(int amount)
        {
            TotalCash -= amount;
        }

        public int Deposit (int amount)
        {
            TotalCash += amount;
            return TotalCash;
        }

        public void AddAccount (Account account)
        {
            Accounts.Add(account);
        } 

        public bool HasFunds(int amount)
        {
            if (TotalCash - amount > 0)
            {
                return true;
            }

            return false;
        }
    }
}
