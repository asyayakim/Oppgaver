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
                new Product { Name = "Cola", Price = 25, Amount = 10, ButtonToBuy = 0 },
                new Product { Name = "Pepsi", Price = 20, Amount = 15, ButtonToBuy = 1 },
                new Product { Name = "Fanta", Price = 22, Amount = 12, ButtonToBuy = 2 },
                new Product { Name = "Sprite", Price = 23, Amount = 8, ButtonToBuy = 3 }
            };
            MoneyInMachine = new List<MoneyInMachine>
            {
                new MoneyInMachine
                {
                    Coin1 = 1, AmountCoin1 = 25,
                    Coin2 = 5, AmountCoin2 = 15,
                    Coin3 = 10, AmountCoin3 = 10,
                    Coin4 = 20, AmountCoin4 = 4,
                }
            };
        }

        public void PrintProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.ButtonToBuy + " " + product.Name);
            }
        }

        public void PaymentProceass(int buyProduct)
        {
            
        }
    }

    public class MoneyInMachine
    {
        public int Coin1 { get; set; }
        public int Coin2 { get; set; }
        public int Coin3 { get; set; }
        public int Coin4 { get; set; }
        public int AmountCoin1 { get; set; }
        public int AmountCoin2 { get; set; }
        public int AmountCoin3 { get; set; }
        public int AmountCoin4 { get; set; }

        public void AddMoney(int amount)
        {
            AmountCoin1 += amount;
            AmountCoin2 += amount;
            AmountCoin2 += amount;
            AmountCoin3 += amount;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int ButtonToBuy { get; set; }
    }

    public class Client
    {
        public MoneyInMachine ClientMoney { get; set; }

        public Client()
        {
            ClientMoney = new MoneyInMachine
            {
                Coin1 = 1, AmountCoin1 = 2,
                Coin2 = 5, AmountCoin2 = 3,
                Coin3 = 10, AmountCoin3 = 1,
                Coin4 = 20, AmountCoin4 = 0
            };
        }
    }

}