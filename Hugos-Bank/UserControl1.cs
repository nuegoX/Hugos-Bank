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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenAccount user control
            OpenAccount openAccount = new OpenAccount();

            // Add the OpenAccount user control to the parent control
            this.Parent.Controls.Add(openAccount);

            // Bring the OpenAccount user control to the front
            openAccount.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Make control for logging into existing account.
        }
    }
}
