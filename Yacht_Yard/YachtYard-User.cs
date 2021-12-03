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
    public partial class YachtYard_User : Form
    {
        Model1 db = new Model1();
        public YachtYard_User()
        {
            InitializeComponent();
        }
        public void FullTable()
        {
            customerBindingSource.DataSource = db.Customer.ToList();//заполняем данные в таблицу из бд
        }
        private void bNazad_Click(object sender, EventArgs e)
        {
            Form1 pmf = new Form1();
            pmf.Show();
            Hide();
        }

        private void YachtYard_User_Load(object sender, EventArgs e)
        {
            FullTable();
        }

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            Customer prod = (Customer)customerBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить пользователя - {prod.FamilyName.ToString()}?",
                "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Customer.Remove(prod);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Внимание! Пользователь успешно удален!", "Успешное удаление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                customerBindingSource.DataSource = db.Customer.ToList();
            }
        }

        private void changeProdBtn_Click(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
