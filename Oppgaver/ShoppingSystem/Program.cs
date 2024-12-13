using Oppgaver.Oppgave330C;

namespace Oppgaver.ShoppingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Products>
            {
                new Electronic("Laptop", "E123456", 14999.99m, 10, 2),
                new Electronic("Smartphone", "E987654", 8999.50m, 50, 1),
                new Food("Apple", "F112233", 3.50m, 100, new DateTime(2024, 12, 31)),
                new Food("Milk", "F445566", 15.99m, 30, new DateTime(2024, 12, 15))
            };
            foreach (var product in products)
            {
                Console.WriteLine(product.PrintInfo(product));
            }
            

        }
    }
}