using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hugos_Bank
{
    public partial class OpenAccount : UserControl
    {
        public OpenAccount()
        {
            InitializeComponent();
            
        }
        Bank bank = new Bank();
        private bool ValidatePassword(String pwd)
        {
            if (string.IsNullOrWhiteSpace(pwd))
            {
                Console.WriteLine("Password cannot be empty or contain only whitespace.");
                return false;
            }
            else if (pwd.Contains(" "))
            {
                Console.WriteLine("Password cannot contain spaces.");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Password = codeBox.Text;
            if (ValidatePassword(Password))
            {
                //CreateBankAccount(Password);
                bank.CreateBankAccount(Password);

                
                Dashboard dashboard = new Dashboard();

               
                this.Parent.Controls.Add(dashboard);

             
                dashboard.BringToFront();

                // Make it change control to the main thing and log in with the correct account.
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
