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
    public partial class Dashboard : UserControl
    {
        public Dashboard(String balance)
        {
            InitializeComponent();
            label3.Text = balance;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
