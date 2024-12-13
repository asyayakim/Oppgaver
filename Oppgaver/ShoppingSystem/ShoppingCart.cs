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
            _products.Add(product);
        }
        public void RemoveProduct(Products product)
        {
            _products.Remove(product);
        }
    }
}