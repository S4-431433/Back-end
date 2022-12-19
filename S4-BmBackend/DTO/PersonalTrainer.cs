namespace S4_BmBackend.DTO
{
    public class PersonalTrainer
    {
        public PersonalTrainer(int id, string name, int age, string department, string email, string number)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
            Email = email;
            Number = number;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Department { get; private set; }
        public string Email { get; private set; }
        public string Number { get; private set; }
    }
}
