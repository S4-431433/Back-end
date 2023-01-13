using S4_BmBackend.Data;

namespace S4_BmBackend.Logic
{
    public class AdminLogic
    {
        Account account = new();
        Product product = new();
        Trainer trainer = new();
         public List<int> GetData()
        {
            List<int> data = new();
            data.Add(GetUserCount());
            data.Add(GetTrainerCount());
            data.Add(GetProductCount());
            data.Add(GetRevenue());
            return data;
        }


        public int GetUserCount()
        {
            return account.GetAll().Count;
        }

        public int GetTrainerCount()
        {
            return trainer.GetAll().Count;
        }

        public int GetProductCount()
        {
            return product.GetAll().Count;
        }

        public int GetRevenue()
        {
            return 21;
        }
    }
}
