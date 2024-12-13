namespace Oppgaver.ShoppingSystem
{

    public class Products : IProducts
    {
        public Products(string name, string registerNumber, decimal price, int quantity)
        {
            Name = name;
            RegisterNumber = registerNumber;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; }
        public string RegisterNumber { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }

        public virtual string PrintInfo()
        {
            return $"Name: {Name}, RegisterNumber: {RegisterNumber}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}