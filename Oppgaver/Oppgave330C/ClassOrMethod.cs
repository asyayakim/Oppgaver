using System.Reflection.PortableExecutable;

namespace Oppgaver.Oppgave330C
{
    public class MachineAutomat
    {
        public List<Product> Products { get; set; }
        public MoneyInMachine MoneyInMachine { get; set; }

        public MachineAutomat()
        {
            Products = new List<Product>
            {
                new Product { Name = "Cola", Price = 25, Amount = 10, ButtonToBuy = 0 },
                new Product { Name = "Pepsi", Price = 20, Amount = 15, ButtonToBuy = 1 },
                new Product { Name = "Fanta", Price = 22, Amount = 12, ButtonToBuy = 2 },
                new Product { Name = "Sprite", Price = 23, Amount = 8, ButtonToBuy = 3 }
            };
            MoneyInMachine = new MoneyInMachine
            {
                Coin1 = 1, AmountCoin1 = 25,
                Coin2 = 5, AmountCoin2 = 15,
                Coin3 = 10, AmountCoin3 = 10,
                Coin4 = 20, AmountCoin4 = 4,
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
            var product = Products.FirstOrDefault(x => x.ButtonToBuy == buyProduct);
            if (product == null || buyProduct < 0)
            {
                Console.WriteLine("Product not found");
                return;
            }

            Console.WriteLine("You selected" + " " + product.Name + " " + product.Price + " kr");
            int clientTotal = Client.TotalMoneyClient();
            if (product.Price > clientTotal)
            {
                Console.WriteLine("Not enough money inserted for"
                                  + product.Name + " "
                                  + product.Price);
                return;
            }

            if (product.Price < clientTotal)
            {
                Client.ClientMoney.GiveChange(product.Price);
                Console.WriteLine("You have " + clientTotal + " kr");
                Client.ClientMoney.AddMoney(-product.Price);
                product.Amount--;
                Console.WriteLine("You have " + clientTotal + " kr left");
                int change = clientTotal - product.Price;
                if (change > 0)
                {
                    Console.WriteLine($"Returning change: {change} kr");
                    MoneyInMachine.GiveChange(change);
                }

                MoneyInMachine.AddMoney(product.Price);
                Console.WriteLine($"Purchase successful. Change: {change}");
                Console.WriteLine("You have " + clientTotal + " kr");
                Console.WriteLine("Money in machine" + " " + MoneyInMachine.AmountCoin1 + " " +
                                  MoneyInMachine.AmountCoin2 + " " + MoneyInMachine.AmountCoin3);
            }
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
            while (amount >= Coin4)
            {
                AmountCoin4++;
                amount -= Coin4;
            }
            while (amount >= Coin3)
            {
                AmountCoin3++;
                amount -= Coin3;
            }
            while (amount >= Coin2)
            {
                AmountCoin2++;
                amount -= Coin2;
            }
            while (amount >= Coin1)
            {
                AmountCoin1++;
                amount -= Coin1;
            }
        }


        public int GetTotalMoney()
        {
            return (Coin1 * AmountCoin1) +
                   (Coin2 * AmountCoin2) +
                   (Coin3 * AmountCoin3) +
                   (Coin4 * AmountCoin4);
        }

        public void GiveChange(int change)
        {
            Console.WriteLine($"You give change to {change} kr");
            while (change >= Coin4 && AmountCoin4 > 0)
            {
                change -= Coin4;
                AmountCoin4--;
            }

            while (change >= Coin3 && AmountCoin3 > 0)
            {
                change -= Coin3;
                AmountCoin3--;
            }

            while (change >= Coin2 && AmountCoin2 > 0)
            {
                change -= Coin2;
                AmountCoin2--;
            }

            while (change >= Coin1 && AmountCoin1 > 0)
            {
                change -= Coin1;
                AmountCoin1--;
            }

            if (change > 0)
            {
                Console.WriteLine($"Unable to return full change. Remaining: {change} kr");
            }
            else
            {
                Console.WriteLine("Change dispensed successfully.");
            }
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
        public static MoneyInMachine ClientMoney { get; set; }

        static Client()
        {
            ClientMoney = new MoneyInMachine
            {
                Coin1 = 1, AmountCoin1 = 2,
                Coin2 = 5, AmountCoin2 = 3,
                Coin3 = 10, AmountCoin3 = 1,
                Coin4 = 20, AmountCoin4 = 0
            };
        }

        public static int TotalMoneyClient()
        {
            return ClientMoney.GetTotalMoney();
        }
    }
}