namespace S4_BmBackend.DTO
{
    public class User
    {
        public Weight Weight { get; set; }
        public GoalDTO Goal { get; set; }
        public PersonalTrainer PersonalTrainer { get; set; }
        public User(string forename, string lastname, string email, string password, string adress, int age, int lenght, DateTime birthday)
        {
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;
            Adress = adress;
            Age = age;
            Length = lenght;
            Birthday = birthday;
        }

        public User(int id, string forename, string lastname, string email, string password, string adress, int age, int lenght, DateTime birthday)
        {
            Id = id;
            Forename = forename;
            Lastname = lastname;
            Email = email;
            Password = password;
            Adress = adress;
            Age = age;
            Length = lenght;
            Birthday = birthday;
        }

        public User(int id, Weight weight, GoalDTO goal, PersonalTrainer personalTrainer)
        {
            Id = id;
            Weight = weight;
            Goal = goal;
            PersonalTrainer = personalTrainer;
        }

        public User()
        {
        }

        public User(GoalDTO goal)
        {
            Goal = goal;
        }

        public int Id { get; set; }
        public string Forename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public int Length { get; set; }
        public DateTime Birthday { get; set; }
    }
}
