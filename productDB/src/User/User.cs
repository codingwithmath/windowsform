using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using productDB.src.Utils;

namespace productDB.src.User.User
{
    class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }

        Database getConnected = new Database();

        public User makeLogin(User user)
        {
            NpgsqlConnection connection = null;

            try
            {
                connection = getConnected.getConnection();


                string queryGetUserLoginInfo = "SELECT id, login, password, admin FROM users WHERE login =@login AND password=@password";

                NpgsqlCommand command = new NpgsqlCommand(queryGetUserLoginInfo, connection);

                command.Parameters.AddWithValue("@login", NpgsqlTypes.NpgsqlDbType.Char, user.login);
                command.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Char, user.password);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                User loggedUser = new User();

                if (dataReader.Read())
                {
                    loggedUser.id = Convert.ToInt16(dataReader["id"]);
                    loggedUser.login = dataReader["login"].ToString();
                    loggedUser.password = dataReader["password"].ToString();
                    loggedUser.admin = Convert.ToBoolean(dataReader["admin"]);
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
