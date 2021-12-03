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
    public partial class YachtYard_Cost : Form
    {
        Model1 db = new Model1();
        public YachtYard_Cost()
        {
            InitializeComponent();
        }

        public void FullTable()
        {
            invoiceBindingSource.DataSource = db.Invoice.ToList();//заполняем данные в таблицу из бд
        }
        private void bNazad_Click(object sender, EventArgs e)
        {
            Form1 pmf = new Form1(); // возвращение к меню
            pmf.Show();
            Hide();
        }

        private void YachtYard_Cost_Load(object sender, EventArgs e)
        {
            FullTable();
        }
    }
}
