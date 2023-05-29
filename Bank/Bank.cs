using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public Bank()
        {

        }
        public List<Account> accounts = new List<Account>();
        public Account currentUser = null;
        public Account targetUser = null;

        public void CreateAccount (string Username, string Password, float Balance)
        {
            Account currentUser = new Account(Username, Password, Balance);
            accounts.Add(new Account(Username, Password, Balance));
        }
        public void RegisterAccount (string Username, string Password, float Balance)
        {
            currentUser = new Account(Username, Password, Balance);
            accounts.Add(currentUser);
        }


    }

    public class Account
    {
        public String Username;
        public String Password;
        public int Pincode;

        public float Balance;

        public Account(string Username, string Password, float Balance)
        {
            this.Username = Username;
            this.Password = Password;
            this.Balance = Balance;
        }

    }
}
