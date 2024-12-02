namespace Oppgaver.Oppgave330C
{
    public class Oppgave330C
    {
        public static void Run()
        {
            Console.WriteLine("Oppgave330C");
            var machineAutomat = new MachineAutomat();
            while (true)
            {
                Console.WriteLine("Available Products:");
                machineAutomat.PrintProducts();
                Console.WriteLine("What do you want to buy?");
                int buyProduct = Convert.ToInt32(Console.ReadLine());
                machineAutomat.PaymentProceass(buyProduct);
                Console.WriteLine("Do you want to buy another product? Press 1 to exit or any other key to continue.");
                var exitInput = Console.ReadLine();
                if (exitInput == "1")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}