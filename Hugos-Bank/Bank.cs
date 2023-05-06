using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugos_Bank
{
    internal class Bank
    {
        private List<BankAccount> accounts;
        private List<Transaction> transactions;

        private String GenerateAccountNumber ()
        {
            return "136421";
        }
        public void CreateBankAccount (String code)
        {
            accounts.Add(new BankAccount(code, GenerateAccountNumber(), 0.0f));
        }

        public void GetAccountInfo ()
        {

        }

        public void MakeTransaction ()
        {

        }

        public Bank() { 
        
        }
    }
}
