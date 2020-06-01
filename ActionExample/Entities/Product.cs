namespace ActionExample.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }

        public override string ToString(){
            return $"{Name}, {Price}";
        }
    }

    
}