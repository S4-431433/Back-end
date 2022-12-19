using S4_BmBackend.DTO;

namespace S4_BmBackend.Logic
{
    public class PtLogic
    {
        //Get
        //Database get method

        //Create
        public PersonalTrainer CreateTrainer(int id, string name, int age, string department, string email, string number)
        {
            PersonalTrainer trainer = new(id, name, age, department, email, number);
            //Send to database
            return trainer;
        }

        //Update
        public bool UpdateTrainer(int id, string name, int age, string department, string email, string number)
        {
            List<PersonalTrainer> trainers = new(); //fill list from database
            var index = trainers.FindIndex(x => x.Id == id);
            if (index > -1)
            {
                trainers[index] = new(id, name, age, department, email, number);
                return true;
            }
            else return false;
        }
    }
}
