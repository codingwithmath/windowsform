using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productDB.src.User.User;


namespace productDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.login = txtUser.Text;
            user.password = txtPassword.Text;

            User loggedUser = user.makeLogin(user);


            if (user.login == loggedUser.login && user.password == loggedUser.password)
            {
                MessageBox.Show("Valid Authentication");
            }
            else
            {
                MessageBox.Show("Invalid Authentication");
            }
        }
    }
}
