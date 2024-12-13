namespace Oppgaver.ShoppingSystem
{
    public class Food : Products
    {
        public Food(string name, string registerNumber, decimal price, int quantity, DateTime expiratonDateTime) : base(name, registerNumber, price, quantity)
        {
            ExpiratonDateTime = expiratonDateTime;
        }

        private DateTime ExpiratonDateTime { get; }

        public void CheckFreshness()
        {
            if (DateTime.Now > ExpiratonDateTime)
            {
                Console.WriteLine("Food expired");
            }
            else if (DateTime.Now <= ExpiratonDateTime)
            {
                Console.WriteLine("Food ok");
            }
        }
        public override string PrintInfo()
        {
            return $"Name: {Name}, RegisterNumber: {RegisterNumber}, Price: {Price}, Quantity: {Quantity}, ExpiratonDateTime: {ExpiratonDateTime}";
        }
    }
}