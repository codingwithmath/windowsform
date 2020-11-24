using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productDB
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
        }
    }
}
