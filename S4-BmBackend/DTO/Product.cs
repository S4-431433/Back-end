namespace S4_BmBackend.DTO
{
    public class Product
    {
        public Product(int id, string name, string description, string effect, List<string> ingredients)
        {
            Id = id;
            Name = name;
            Description = description;
            Effect = effect;
            Ingredients = ingredients;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Effect { get; private set; }
        public List<string> Ingredients { get; private set; }
    }
}
