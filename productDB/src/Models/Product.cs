using System;
using Npgsql;
using productDB.src.Utils.Database;

namespace productDB.src.Models.Product
{
    class Product
    {
        public string Title;
        public string Category;
        public string Description;
        public string Url;
        public DateTime timestamps { get; set; }
        public Product()
        {

        }

        public Product(string title, string category, string description, string url)
        {
            Title = title;
            Category = category;
            Description = description;
            Url = url;
        }

        Database database = new Database();

        public int createProduct(Product product)
        {
            NpgsqlConnection connection = null;
            try
            {
                connection = database.getConnection();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    string queryCreateNewProduct = "INSERT INTO products (title, category, description, url, timestamps) " +
                        "VALUES (@title, @category, @description, @url, @timestamps)";

                    command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Char, product.Title);
                    command.Parameters.AddWithValue("@category", NpgsqlTypes.NpgsqlDbType.Char, product.Category);
                    command.Parameters.AddWithValue("@description", NpgsqlTypes.NpgsqlDbType.Char, product.Description);
                    command.Parameters.AddWithValue("@url", NpgsqlTypes.NpgsqlDbType.Char, product.Url);
                    command.Parameters.AddWithValue("@timestamps", NpgsqlTypes.NpgsqlDbType.Date, product.timestamps);

                    command.CommandText = queryCreateNewProduct;
                    command.CommandType = System.Data.CommandType.Text;

                    int result = command.ExecuteNonQuery();

                    if (result == 0)
                    {
                        throw new Exception("Error when creating product");
                    } else
                    {
                        return result;
                    }
                }
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

        public string searchProduct(string title)
        {
            NpgsqlConnection connection = null;

            try
            {
                connection = database.getConnection();

                string queryProduct = "SELECT title FROM products WHERE title = @title";
                
                NpgsqlCommand command = new NpgsqlCommand(queryProduct, connection);

                command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Char, title);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                string result = null;

                if (dataReader.Read())
                {
                    result = dataReader["title"].ToString();
                }

                return result;
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
