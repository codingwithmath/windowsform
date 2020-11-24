using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productDB.src.Models.Product;

namespace productDB
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            string title = txtDeleteTitle.Text.ToString();

            int result = product.deleteProduct(title);

            if (result == 0)
            {
                MessageBox.Show("Nenhum produto encontrado! :(");
            }
            else
            {
                MessageBox.Show("Produto excluido com sucesso! :)");
            }
        }
    }
}
