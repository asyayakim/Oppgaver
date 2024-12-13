namespace Oppgaver.ShoppingSystem
{

    public class Products
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
        public int Quantity { get; }
        
        public string PrintInfo(Products product)
        {
            return $"Name: {product.Name}, RegisterNumber: {product.RegisterNumber}, Price: {product.Price}, Quantity: {product.Quantity}";
        }
    }
}