using System;
using Npgsql;
using productDB.src.Utils.Database;

namespace productDB.src.Models.Product
{
    class Product
    {
        public string id { get; set; }
        public DateTime timestamps { get; set; }
        public DateTime updatedAt { get; set; }

        public string Title;
        public string Category;
        public string Description;
        public string Url;
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

        public Product searchProduct(string title)
        {
            NpgsqlConnection connection = null;

            try
            {
                connection = database.getConnection();

                string queryProduct = "SELECT id, title, category, description, url, timestamps, updated_at FROM products WHERE title = @title";
                
                NpgsqlCommand command = new NpgsqlCommand(queryProduct, connection);

                command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Char, title);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                Product product = new Product();

                if (dataReader.Read())
                {
                    product.id = dataReader["id"].ToString();
                    product.Title = dataReader["title"].ToString();
                    product.Category = dataReader["category"].ToString();
                    product.Description = dataReader["description"].ToString();
                    product.Url = dataReader["url"].ToString();
                    product.timestamps = Convert.ToDateTime(dataReader["timestamps"].ToString());

                    if (dataReader["updated_at"].ToString() != "")
                    {
                        product.updatedAt = Convert.ToDateTime(dataReader["updated_at"].ToString());
                    }
                }

                return product;
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

        public int updateProduct (string title, string value, string column)
        {
            Product productExists = searchProduct(title);

            if (productExists.Title != title)
            {
                return 0;
            }

            NpgsqlConnection connection = null;
            
            try
            {
                connection = database.getConnection();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    string queryUpdateProduct = "UPDATE products SET " + column + "= @value, updated_at = @updateTime WHERE title = @title";

                    command.Parameters.AddWithValue("@value", NpgsqlTypes.NpgsqlDbType.Char, value);
                    command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Char, title);
                    command.Parameters.AddWithValue("@updateTime", NpgsqlTypes.NpgsqlDbType.Date, DateTime.Now);

                    command.CommandText = queryUpdateProduct;
                    command.CommandType = System.Data.CommandType.Text;

                    int result = command.ExecuteNonQuery();

                    if (result == 0)
                    {
                        throw new Exception("Error while updating product");
                    }
                    else
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

        public int deleteProduct (string title)
        {
            Product productExists = searchProduct(title);

            if (productExists.Title != title)
            {
                return 0;
            }

            NpgsqlConnection connection = null;

            try
            {
                connection = database.getConnection();

                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    string queryUpdateProduct = "DELETE FROM products WHERE title = @title";

                    command.Parameters.AddWithValue("@title", NpgsqlTypes.NpgsqlDbType.Char, title);

                    command.CommandText = queryUpdateProduct;
                    command.CommandType = System.Data.CommandType.Text;

                    int result = command.ExecuteNonQuery();

                    if (result == 0)
                    {
                        throw new Exception("Error while updating product");
                    }
                    else
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
    }
}
