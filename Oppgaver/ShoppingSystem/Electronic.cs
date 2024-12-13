namespace Oppgaver.ShoppingSystem
{

    public class Electronic : Products
    {
        public Electronic(string name, string registerNumber, decimal price, int quantity, int warantyDuration) : base(name, registerNumber, price, quantity)
        {
            WarantyDuration = warantyDuration;
        }

        public int WarantyDuration { get; }
        public override string PrintInfo()
        {
            return $"Name: {Name}, RegisterNumber: {RegisterNumber}, Price: {Price}, Quantity: {Quantity}, WarantyDuration: {WarantyDuration}";
        }
    }
}