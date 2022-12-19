using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Account
    {
        private string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";

        public bool testDatabase()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CreateUser(User user)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"INSERT INTO `BodyMovement`.`users` (`forename`, `lastname`, `email`, `password`, `adress`, `age`, `length`, `birthday`) VALUES('{user.Forename}', '{user.Lastname}', '{user.Email}', '{user.Password}', '{user.Adress}', '{user.Age}', '{user.Lenght}', '{user.Birthday.ToString("yyyy-MM-dd")}')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
