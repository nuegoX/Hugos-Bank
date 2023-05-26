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

        private String RandomizeCardnumber ()
        {
            Random random = new Random();
            String bin = "123456"; 
            String cardNumber = bin;

            // Generate the remaining 10 digits randomly
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 10);
                cardNumber += randomNumber;
            }

            return cardNumber;
        }
        public void CreateAccount (string Username, string Password, int Pincode, int Cardnumber, float Balance)
        {
            Account currentUser = new Account(Username, Password, Pincode, Cardnumber, Balance);
            accounts.Add(new Account(Username, Password, Pincode, Cardnumber, Balance));
        }
        public void RegisterAccount (string Username, string Password, int Pincode, int Cardnumber, float Balance)
        {
            Account currentUser = new Account(Username, Password, Pincode, Cardnumber, Balance);
            accounts.Add(currentUser);
        }
        public void LoginUser ()
        {
            
        }

    }

    public class Account
    {
        public String Username;
        public String Password;
        public int Pincode;
        public int Cardnumber;
        public float Balance;

        public Account(string Username, string Password, int Pincode, int Cardnumber, float Balance)
        {
            this.Username = Username;
            this.Password = Password;
            this.Cardnumber = Cardnumber;
            this.Balance = Balance;
            this.Pincode = Pincode;
        }

    }
}
