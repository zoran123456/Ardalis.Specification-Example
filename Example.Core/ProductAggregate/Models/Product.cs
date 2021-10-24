namespace Example.Core.ProductAggregate.Models
{
    public class Product : Interfaces.IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
