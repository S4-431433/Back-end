using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Goal
    {
        private readonly string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";
        public List<GoalDTO> Goals = new();

        public List<GoalDTO> Get(int id)
        {
            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new($" SELECT * FROM `BodyMovement`.`goal` WHERE `id` = '{id}'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GoalDTO goal = new();
                    goal.Id = int.Parse(reader["id"].ToString());
                    goal.Bones = double.Parse(reader["bones"].ToString());
                    goal.Muscle = double.Parse(reader["muscle"].ToString());
                    goal.Fat = double.Parse(reader["fat"].ToString());
                    goal.FatPercentage = double.Parse(reader["fatpercentage"].ToString());
                    goal.Mass = double.Parse(reader["mass"].ToString());
                    goal.BMR = double.Parse(reader["bmr"].ToString());
                    goal.Fluid = double.Parse(reader["fluid"].ToString());
                    goal.FluidPercentage = double.Parse(reader["fluidpercentage"].ToString());
                    Goals.Add(goal);
                }
                conn.Close();
                return Goals;
            }
            catch (Exception ex)
            {
                return Goals;
            }
        }
    }
}
