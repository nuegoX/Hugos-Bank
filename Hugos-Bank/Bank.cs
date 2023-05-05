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
        public void CreateBankAccount (String code, String AccountNumber)
        {
            accounts.Add(new BankAccount(code, AccountNumber));
        }
        public void RemoveAccountFromList ()
        {

        }
        public void GetAccountInfo ()
        {

        }
        public void Transact ()
        {

        }
        public Bank() { }
    }
}
