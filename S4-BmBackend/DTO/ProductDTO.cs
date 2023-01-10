namespace S4_BmBackend.DTO
{
    public class ProductDTO
    {
        public ProductDTO(int id, string name, string description, string effect, string category, int weight, string flavor, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Effect = effect;
            Category = category;
            Weight = weight;    
            Flavor = flavor;
            Price = price;
        }

        public ProductDTO()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Effect { get;  set; }
        public string Category { get; set; }
        public int Weight { get; set; }
        public string Flavor { get; set; }
        public decimal Price { get; set; }
    }
}
