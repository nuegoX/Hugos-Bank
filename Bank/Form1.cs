using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:
            // Create a bank object and then through inheritance all possible bank accounts through loading in a text file that is created if it doesn't exist already.


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = textBox1.Text;
            String Password = textBox2.Text;
        }
    }
}
