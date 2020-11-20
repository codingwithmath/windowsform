using System;
using Npgsql;
using productDB.src.Utils.Database;

namespace productDB.src.Models.User
{
    class User
    {
        public int Id;
        public string Login;
        public string Password;
        public bool Admin;

        public User ()
        {

        }

        public User (int id, string login, string password, bool admin)
        {
            Id = id;
            Login = login;
            Password = password;
            Admin = admin;
        }

        Database database = new Database();

        public User makeLogin(User user)
        {
            NpgsqlConnection connection = null;

            try
            {
                connection = database.getConnection();


                string queryGetUserLoginInfo = "SELECT id, login, password, admin FROM users WHERE login =@login AND password=@password";

                NpgsqlCommand command = new NpgsqlCommand(queryGetUserLoginInfo, connection);

                command.Parameters.AddWithValue("@login", NpgsqlTypes.NpgsqlDbType.Char, user.Login);
                command.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Char, user.Password);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                User loggedUser = new User();

                if (dataReader.Read())
                {
                    loggedUser.Id = Convert.ToInt16(dataReader["id"]);
                    loggedUser.Login = dataReader["login"].ToString();
                    loggedUser.Password = dataReader["password"].ToString();
                    loggedUser.Admin = Convert.ToBoolean(dataReader["admin"]);
                }

                return loggedUser;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

    }
}
