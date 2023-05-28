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
            
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            // TODO:
            // Create a bank object and then through inheritance all possible bank accounts through loading in a text file that is created if it doesn't exist already.
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            foreach (Account acc in bank.accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    // TODO: Assign user to the CurrentUser name and remove the from the list, and then go to the dashboard and render everything with appropriate labels.
                    bank.currentUser = acc;
                    
                    break;
                }
                if (bank.currentUser != null)
                {
                    // found a matching account. Now you can reference the object as needed.
                    // The object is still within the accountList, so there is no duplicate.
                }
                else
                {
                    // No matching account found
                }
            }
        }

    }
}
