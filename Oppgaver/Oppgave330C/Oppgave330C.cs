namespace Oppgaver.Oppgave330C
{
    public class Oppgave330C
    {
        public static void Run()
        {
            Console.WriteLine("Oppgave330C");
            var machineAutomat = new MachineAutomat();
            //var product = machineAutomat.CreateProduct("ProductName", 25, 10);
            //var customer = machineAutomat.CreateCustomer("CustomerName", 50);
            machineAutomat.PrintProducts();
            //machineAutomat.BuyUnit();
            Console.WriteLine("What do you want to buy?");
            int buyProduct = Convert.ToInt32(Console.ReadLine());
            machineAutomat.PaymentProceass(buyProduct);
        }
    }
}