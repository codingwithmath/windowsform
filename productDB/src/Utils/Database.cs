using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace productDB.src.Utils
{
    class Database
    {
        private static string host = "172.17.4.218";
        private static string port = "5432";
        private static string user = "postgres";
        private static string password = "postgres";
        private static string database = "postgres";
        public NpgsqlConnection getConnection()
        {
            try
            {
                string stringConnection = String.Format(
                    "Server ={0}; " +
                    "Port = {1};" +
                    "User Id = {2};" +
                    "Password ={3};" +
                    "Database ={4}",
                    host,
                    port,
                    user,
                    password,
                    database
               );

                NpgsqlConnection connection = new NpgsqlConnection(stringConnection);
                connection.Open();

                return connection;
            } 
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
