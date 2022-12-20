namespace S4_BmBackend.DTO
{
    public class PersonalTrainer
    {
        public PersonalTrainer()
        {
        }

        public PersonalTrainer(int id, string name, int age, string department, string email, string number)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
            Email = email;
            Number = number;
        }

        public PersonalTrainer(string name, int age, string department, string email, string number)
        {
            Name = name;
            Age = age;
            Department = department;
            Email = email;
            Number = number;
        }
        public int Id { get;  set; }
        public string Name { get;  set; }
        public int Age { get;  set; }
        public string Department { get;  set; }
        public string Email { get;  set; }
        public string Number { get;  set; }
    }
}
