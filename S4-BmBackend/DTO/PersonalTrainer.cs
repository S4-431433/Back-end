namespace S4_BmBackend.DTO
{
    public class PersonalTrainer
    {
        public PersonalTrainer(int id, string name, int age, string department)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Department { get; private set; }
    }
}
