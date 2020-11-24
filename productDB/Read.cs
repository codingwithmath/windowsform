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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Title = txtSearchProduct.Text.ToLower();

            Product searchedProduct = product.searchProduct(product.Title);

            if (product.Title == searchedProduct.Title)
            {
                dataGridView.Rows.Clear();

                string[] dataGridViewLine = new string[]
                {
                    searchedProduct.id.ToString(),
                    searchedProduct.Title.ToString(),
                    searchedProduct.Category.ToString(),
                    searchedProduct.Description.ToString(),
                    searchedProduct.Url.ToString(),
                    Convert.ToString(searchedProduct.timestamps),
                    Convert.ToString(searchedProduct.updatedAt)
                };

                dataGridView.Rows.Add(dataGridViewLine);
            } else
            {
                MessageBox.Show("Produto não encontrado :(");
            }
        }
    }
}
