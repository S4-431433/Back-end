using MySql.Data.MySqlClient;
using S4_BmBackend.DTO;

namespace S4_BmBackend.Data
{
    public class Weight
    {
        private readonly string myConnectionString = "Server=127.0.0.1;Port=3306;Database=BodyMovement;Uid=root;Pwd=Fontys123;";
        public List<Weight> weight = new();


    }
}
