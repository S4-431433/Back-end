using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Account
    {
        private readonly string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";
        public List<User> Users = new();
        Goal goal = new();

        public List<User> Get(int id)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`users` WHERE `id` = '{id}'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new();
                    user.Id = int.Parse(reader["id"].ToString());
                    user.Forename = reader["forename"].ToString();
                    user.Lastname = reader["lastname"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Adress = reader["adress"].ToString();
                    user.Age = int.Parse(reader["age"].ToString());
                    user.Length = int.Parse(reader["length"].ToString());
                    user.Birthday = Convert.ToDateTime(reader["birthday"]);
                    user.Goal = goal.Get(id)[0];
                    Users.Add(user);
                }
                conn.Close();
                return Users;
            }
            catch (Exception ex)
            {
                return Users;
            }
        }

        public List<User> GetAll()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`users`", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new();
                    user.Id = int.Parse(reader["id"].ToString());
                    user.Forename = reader["forename"].ToString();
                    user.Lastname = reader["lastname"].ToString();
                    user.Email = reader["email"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Adress = reader["adress"].ToString();
                    user.Age = int.Parse(reader["age"].ToString());
                    user.Length = int.Parse(reader["length"].ToString());
                    user.Birthday = Convert.ToDateTime(reader["birthday"]);
                    Users.Add(user);
                }
                conn.Close();
                return Users;
            }
            catch (Exception)
            {
                return Users;
            }
        }


        public bool Create(User user)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"INSERT INTO `BodyMovement`.`users` (`forename`, `lastname`, `email`, `password`, `adress`, `age`, `length`, `birthday`) VALUES('{user.Forename}', '{user.Lastname}', '{user.Email}', '{user.Password}', '{user.Adress}', '{user.Age}', '{user.Length}', '{user.Birthday.ToString("yyyy-MM-dd")}')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(int id, User user)
        {
            MySqlConnection conn = new(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"UPDATE `BodyMovement`.`users` SET `forename` = '{user.Forename}', `lastname` = '{user.Lastname}', `email` = '{user.Email}', `password` = '{user.Password}', `adress` = '{user.Adress}', `age` = '{user.Age}', `length` = '{user.Length}', `birthday` = '{user.Birthday.ToString("yyyy-MM-dd")}' WHERE (`id` = '{id}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            MySqlConnection conn = new(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"DELETE FROM `BodyMovement`.`users` WHERE (`id` = '{id}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
