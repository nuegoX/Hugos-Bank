using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            bank.CreateAccount("Admin", "Password",  10.0f);
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            // TODO:
            // Create a bank object and then through inheritance all possible bank accounts through loading in a text file that is created if it doesn't exist already.
           

            
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

            if (ValidUsername(username) && ValidPassword(password))
            {

            foreach (Account acc in bank.accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    // TODO: Assign user to the CurrentUser name and remove the from the list, and then go to the dashboard and render everything with appropriate labels.
                    bank.currentUser = acc;
                    Form2 form2 = new Form2();

                    form2.Show();
                    Hide();
                    break;
                }
                if (bank.currentUser != null)
                {
                    // found a matching account. Now you can reference the object as needed.
                    // The object is still within the accountList, so there is no duplicate.
                }
                else
                {
                    // No matching account found. Register account..
                    bank.RegisterAccount(username, password, 0.0f);
                    Form2 form2 = new Form2();
                    form2.Show();
                    Hide();
                    break;
                }
            }
            } else
            {
                Console.WriteLine("Username and/or Password is invalid.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
