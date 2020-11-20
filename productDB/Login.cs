using System;
using System.Windows.Forms;
using productDB.src.Models.User;

namespace productDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static bool isAuthenticationValid(User user, string login, string password)
        {
            if (user.Login == login && user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Login = txtUser.Text;
            user.Password = txtPassword.Text;

            User loggedUser = user.makeLogin(user);

            bool isUserAuthenticated = isAuthenticationValid(user, loggedUser.Login, loggedUser.Password);

            if (isUserAuthenticated == true)
            {
                MessageBox.Show("Valid Authentication");

                Product product = new Product();
                product.Show();
            }
            else
            {
                MessageBox.Show("Invalid Authentication");
            }
        }
    }
}
