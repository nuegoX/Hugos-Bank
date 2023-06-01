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
        // List for all the accounts.
        public List<Account> accounts = new List<Account>();

        // Variable for the current logged in user.
        public Account currentUser = null;

        // Variable for the selected user to transfer money to.
        public Account targetUser = null;

        // Method for creating an account and adding to the list.
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
    
    [Serializable]
    public class Account
    {
        public String Username;
        public String Password;
        public float Balance;

        public Account(string Username, string Password, float Balance)
        {
            this.Username = Username;
            this.Password = Password;
            this.Balance = Balance;
        }

    }
}
