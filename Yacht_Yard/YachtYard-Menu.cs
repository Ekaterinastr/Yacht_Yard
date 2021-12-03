using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yacht_Yard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bVixod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bUser_Click(object sender, EventArgs e)
        {
            YachtYard_User pmf = new YachtYard_User();
            pmf.Show();
            Hide();
        }

        private void bProduct_Click(object sender, EventArgs e)
        {
            YachtYard_Product pmf = new YachtYard_Product();
            pmf.Show();
            Hide();
        }

        private void bCost_Click(object sender, EventArgs e)
        {
            YachtYard_Cost pmf = new YachtYard_Cost();
            pmf.Show();
            Hide();
        }
    }
}
