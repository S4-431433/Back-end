using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Product
    {
        private readonly string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";
        List<ProductDTO> products = new();

        public List<ProductDTO> Get(int id)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`products` WHERE `id` = '{id}'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDTO _product = new();
                    _product.Id = int.Parse(reader["id"].ToString());
                    _product.Name = reader["name"].ToString();
                    _product.Description = reader["description"].ToString();
                    _product.Effect = reader["effect"].ToString();
                    _product.Category = reader["category"].ToString();
                    _product.Weight = int.Parse(reader["weigth"].ToString());
                    _product.Flavor = reader["flavor"].ToString();
                    _product.Price = decimal.Parse(reader["price"].ToString());

                    products.Add(_product);
                }
                conn.Close();
                return products;
            }
            catch (Exception ex)
            {
                return products;
            }
        }
        public List<ProductDTO> GetAll()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`products`", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDTO _product = new();
                    _product.Id = int.Parse(reader["id"].ToString());
                    _product.Name = reader["name"].ToString();
                    _product.Description = reader["description"].ToString();
                    _product.Effect = reader["effect"].ToString();
                    _product.Category = reader["category"].ToString();
                    _product.Weight = int.Parse(reader["weigth"].ToString());
                    _product.Flavor = reader["flavor"].ToString();
                    _product.Price = decimal.Parse(reader["price"].ToString());

                    products.Add(_product);
                }
                conn.Close();
                return products;
            }
            catch (Exception ex)
            {
                return products;
            }
        }
    }
}
