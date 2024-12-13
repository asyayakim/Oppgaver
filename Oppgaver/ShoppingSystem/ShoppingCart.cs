using Oppgaver.Oppgave330C;

namespace Oppgaver.ShoppingSystem
{
    public class ShoppingCart
    {
        private readonly List<Products> _products;
        public ShoppingCart()
        {
            _products = new List<Products>();
        }
        
        
        public void AddProduct(Products product)
        {
            _products.Add(new Products(product.Name, product.RegisterNumber, product.Price, 1));
           
            FixQuantotyInStock(product);
        }

        private void FixQuantotyInStock(Products product)
        {
            product.Quantity -= 1;
        }

        public void RemoveProduct(Products product)
        {
            _products.Remove(product);
        }

        public void DisplayProductsInTheCart(List<Products> products)
        {
            _products.ForEach(product => Console.WriteLine($"Name: {product.Name}, RegisterNumber: " +
                                                           $"{product.RegisterNumber}, Price: {product.Price}," +
                                                           $" Quantity: {product.Quantity}"));
        }
       
    }
}