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
        private String AccountNumber;
        private float Balance = 0.0f;

        // Constructor for the BankAccount class.
        public BankAccount(String code, String accountNumber)
        {
            Code = code;
            AccountNumber = accountNumber;
        }

        // Method for adding x amount to the account.
        private void AddBalance (float Amount)
        {
            Balance += Amount;
        }

        // Method for removing x amount from the account.
        private void DeductBalance (float Amount)
        {
            Balance -= Amount;
        }
    }
}
