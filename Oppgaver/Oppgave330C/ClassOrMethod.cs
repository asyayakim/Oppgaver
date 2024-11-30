using System.Reflection.PortableExecutable;

namespace Oppgaver.Oppgave330C
{
    public class MachineAutomat
    {
     public List<Product> Products { get; set; }
     public List<MoneyInMachine> MoneyInMachine { get; set; }

     public MachineAutomat()
     {
         Products = new List<Product>
         {
             new Product { Name = "Cola", Price = 25, Amount = 10 },
             new Product { Name = "Pepsi", Price = 20, Amount = 15 },
             new Product { Name = "Fanta", Price = 22, Amount = 12 },
             new Product { Name = "Sprite", Price = 23, Amount = 8 }
         };
         MoneyInMachine = new List<MoneyInMachine>
         {
             new MoneyInMachine{}
         };
     }
    }
    

    public class MoneyInMachine
    {
        public string Coin1 { get; set; }
        public string Coin2 { get; set; }
        public string Coin3 { get; set; }
        public string Coin4 { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}