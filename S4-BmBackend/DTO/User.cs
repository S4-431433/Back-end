namespace S4_BmBackend.DTO
{
    public class User
    {
        public Weight Weight { get; set; }
        public Goal Goal { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
        public User(string forename, string lastname, string email, string password, string adress, int age, int lenght, DateTime birthday)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;
            Adress = adress;
            Age = age;
            Lenght = lenght;
            Birthday = birthday;
        }

        public User(int id, Weight weight, Goal goal, PersonalTrainer personalTrainer)
        {
            Id = id;
            Weight = weight;
            Goal = goal;
            PersonalTrainer = personalTrainer;
        }

        public int Id { get; set; }
        public string Forename { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Adress { get; private set; }
        public int Age { get; private set; }
        public int Lenght { get; private set; }
        public DateTime Birthday { get; set; }
    }
}
