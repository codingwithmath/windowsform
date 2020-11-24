using System;
using System.Windows.Forms;
using productDB.src.Models.Product;

namespace productDB
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        Product product = new Product();

        private void updateBtn_Click(object sender, EventArgs e)
        {
            product.Title = txtProductTitle.Text.ToLower();

            string value = txtUpdateTitle.Text.ToLower();

            int result = product.updateProduct(product.Title, value, "title");

            if (result == 0)
            {
                MessageBox.Show("Produto não encontrado :(!");
            } else
            {
                MessageBox.Show("Produto atualizado!");

                txtUpdateTitle.Clear();
                txtProductTitle.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            product.Title = txtProductTitle.Text.ToLower();

            string value = txtUpdateCategory.Text.ToLower();

            int result = product.updateProduct(product.Title, value, "category");

            if (result == 0)
            {
                MessageBox.Show("Produto não encontrado :(!");
            }
            else
            {
                MessageBox.Show("Produto atualizado!");

                txtProductTitle.Clear();
                txtUpdateCategory.Clear();
            }
        }

        private void updateDescriptionBtn_Click(object sender, EventArgs e)
        {
            product.Title = txtProductTitle.Text.ToLower();

            string value = txtUpdateDescription.Text.ToLower();

            int result = product.updateProduct(product.Title, value, "description");

            if (result == 0)
            {
                MessageBox.Show("Produto não encontrado :(!");
            }
            else
            {
                MessageBox.Show("Produto atualizado!");

                txtUpdateDescription.Clear();
                txtProductTitle.Clear();
            }
        }

        private void updateUrlBtn_Click(object sender, EventArgs e)
        {
            product.Title = txtProductTitle.Text.ToLower();

            string value = txtUpdateUrl.Text.ToLower();

            int result = product.updateProduct(product.Title, value, "url");

            if (result == 0)
            {
                MessageBox.Show("Produto não encontrado :(!");
            }
            else
            {
                MessageBox.Show("Produto atualizado!");

                txtUpdateUrl.Clear();
                txtProductTitle.Clear();
            }
        }
    }
}
