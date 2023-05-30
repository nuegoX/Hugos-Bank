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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Transfer money
            String Receiver = textBox1.Text;
            String Amount = textBox2.Text;
            float number;
            bool success = float.TryParse(Amount, out number);
            bool FoundUser = false;

            if (success && number > 0)    
            {
                // Do you have enough balance for the transaction?
                if (number <= Form1.Instance.bank.currentUser.Balance) { 

                    // Check if receiver exists.
                    foreach (Account acc in Form1.Instance.bank.accounts)
                    {
                        if (acc.Username == Receiver)
                        {
                            FoundUser = true;
                            Form1.Instance.bank.targetUser = acc;
                            Console.WriteLine("Found target user.");

                            // Transfer balance
                            Form1.Instance.bank.currentUser.Balance -= number;
                            Form1.Instance.bank.targetUser.Balance += number;
                            UpdateLabels();
                            label12.Visible = false;
                            break;
                        }
                    }
                    if (!FoundUser) 
                    {
                        label12.Visible = true;
                    }
                }
                else
                {
                    label12.Visible = true;
                }
            }
            else
            {
                label12.Visible = true;
            }
        }

        private void UpdateLabels()
        {
            label1.Text = Form1.Instance.bank.currentUser.Username;
            label3.Text = "Your balance: " + Form1.Instance.bank.currentUser.Balance.ToString() +"$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Deposit money
            string numberString = textBox3.Text;
            float number;
            bool success = float.TryParse(numberString, out number);

            if (success)
            {
                // So you can't deposit a negative amount.
                if (number > 0)
                {
                    Form1.Instance.bank.currentUser.Balance = Form1.Instance.bank.currentUser.Balance + number;
                    UpdateLabels();
                    label10.Visible = false;
                }
                else
                {
                    Console.WriteLine("Has to be above 0");
                    label10.Visible = true;
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input. Must be a number.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Withdraw money
            string numberString = textBox4.Text;
            float number;
            bool success = float.TryParse(numberString, out number);

            if (success)
            {
                if (Form1.Instance.bank.currentUser.Balance - number >= 0 && number > 0) {
                    Form1.Instance.bank.currentUser.Balance = Form1.Instance.bank.currentUser.Balance - number;
                    UpdateLabels();
                    label11.Visible = false;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                    label11.Visible = true;
                }
                
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
