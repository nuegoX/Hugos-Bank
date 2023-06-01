using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Bank bank = new Bank();
        public string filePath;

        public Form1()
        {
            InitializeComponent();
            Instance = this;

            // Defining path for the file where all the accounts are stored.
            filePath = "bank.accounts";

            // Deserialize the bankAccounts list from the file if it exists.
            if (File.Exists(filePath))
            {
                DeserializeBankAccountsFromFile(bank.accounts, filePath);

                // Print the deserialized bankAccounts list
                foreach (var account in bank.accounts)
                {
                    Console.WriteLine($"Username: {account.Username}, Password: {account.Password}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine("Bank account file does not exist.");
            }
        }

        // Function for saving the accounts to the file.
        public void SerializeBankAccountsToFile(List<Account> bankAccounts, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = File.Open(filePath, FileMode.Create))
            {
                formatter.Serialize(fileStream, bankAccounts);
            }
        }

        // Loading the accounts from the file and adding them to my list.
        public void DeserializeBankAccountsFromFile(List<Account> bankAccounts, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = File.OpenRead(filePath))
            {
                var deserializedAccounts = (List<Account>)formatter.Deserialize(fileStream);
                bankAccounts.AddRange(deserializedAccounts);
            }
        }
    

    private void Form1_Load (object sender, EventArgs e)
        {
    
            
        }

        public bool ValidUsername(string username)
        {
            // Check if the username is not empty
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            // Check if the username has at least 4 characters
            if (username.Length < 4)
            {
                return false;
            }

            // Check if the username contains whitespace
            if (username.Contains(" "))
            {
                return false;
            }

            // All checks passed, username is valid
            return true;
        }
        public bool ValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            if (password.Length < 4)
            {
                return false;
            }
          
            if (password.Contains(" "))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool userExists = false;

            if (ValidUsername(username) && ValidPassword(password))
            {
                foreach (Account acc in bank.accounts)
                {
                    if (acc.Username == username)
                    {
                        userExists = true;
                        if (acc.Password != password)
                        {
                            Console.WriteLine("Incorrect password.");
                            label2.Visible = true;
                        }
                        else
                        {
                            bank.currentUser = acc;
                            Form2 form2 = new Form2();
                            form2.Show();
                            Hide();
                        }
                        break; // Break out of the loop once a matching account is found
                    }
                }

                if (!userExists)
                {
                    // No matching account found. Register account.
                    bank.RegisterAccount(username, password, 0.0f);
                    Form2 form2 = new Form2();
                    form2.Show();
                    Hide();
                }
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
