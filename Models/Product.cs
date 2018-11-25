using UnitOfWorkProject.Enums;

namespace UnitOfWorkProject.Models
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public ECategory Category { get; private set; }

        public Product(string name, string description, double price, ECategory category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}