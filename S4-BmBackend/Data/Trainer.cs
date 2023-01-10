using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Trainer
    {
        private readonly string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";
        List<PersonalTrainer> trainers = new();

        public List<PersonalTrainer> Get(int id)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`personal_trainers` WHERE `id` = '{id}'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PersonalTrainer trainer = new();
                    trainer.Id = int.Parse(reader["id"].ToString());
                    trainer.Name = reader["name"].ToString();
                    trainer.Age = int.Parse(reader["age"].ToString());
                    trainer.Email = reader["email"].ToString();
                    trainer.Department = reader["department"].ToString();
                    trainer.Number = reader["number"].ToString();
                    trainers.Add(trainer);
                }
                conn.Close();
                return trainers;
            }
            catch (Exception ex)
            {
                return trainers;
            }
        }
        public List<PersonalTrainer> GetAll()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`personal_trainers`", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PersonalTrainer trainer = new();
                    trainer.Id = int.Parse(reader["id"].ToString());
                    trainer.Name = reader["name"].ToString();
                    trainer.Age = int.Parse(reader["age"].ToString());
                    trainer.Email = reader["email"].ToString();
                    trainer.Department = reader["department"].ToString();
                    trainer.Number = reader["number"].ToString();
                    trainers.Add(trainer);
                }
                conn.Close();
                return trainers;
            }
            catch (Exception ex)
            {
                return trainers;
            }
        }

        public bool Create(PersonalTrainer trainer)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"INSERT INTO `BodyMovement`.`personal_trainers` (`name`, `age`, `department`, `email`, `number`) VALUES('{trainer.Name}', '{trainer.Age}', '{trainer.Department}', '{trainer.Email}', '{trainer.Number}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(int id, PersonalTrainer trainer)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"UPDATE `BodyMovement`.`personal_trainers` SET `name` = '{trainer.Name}', `age` = '{trainer.Age}', `department` = '{trainer.Department}', `email` = '{trainer.Email}', `number` = '{trainer.Number}' WHERE (`id` = '{id}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($"DELETE FROM `BodyMovement`.`personal_trainers` WHERE (`id` = '{id}')", conn);
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
