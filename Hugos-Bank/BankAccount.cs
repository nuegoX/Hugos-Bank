using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugos_Bank
{
    internal class BankAccount
    {
        // Stores values for the bank account.
        private String Code;
        private int AccountNumber;
        private int Balance;

        // Constructor for the BankAccount class.
        public BankAccount(string code, int accountNumber)
        {
            Code = code;
            AccountNumber = accountNumber;
        }

        // Method for adding x amount to the account.
        private void AddBalance (int Amount)
        {
            Balance += Amount;
        }

        // Method for removing x amount from the account.
        private void DeductBalance (int Amount)
        {
            Balance -= Amount;
        }
    }
}
