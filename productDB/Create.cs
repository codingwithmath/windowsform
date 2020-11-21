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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Title = txtTitle.Text.ToLower();
            product.Category = txtCategory.Text.ToLower();
            product.Description = txtDescription.Text.ToLower();
            product.Url = txtUrl.Text.ToLower();
            product.timestamps = DateTime.Now;

            string productsAlreadyExists = product.searchProduct(product.Title);

            if (productsAlreadyExists != null)
            {
                MessageBox.Show("Produto já existe!");

            } else
            {
                int result = product.createProduct(product);

                if (result != 0)
                {
                    MessageBox.Show("Produto criado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro inesperado :(");
                }
            }

        }
    }
}
