namespace Oppgaver.ShoppingSystem;

public interface IProducts
{
    string PrintInfo();
    public string Name { get; }
    public string RegisterNumber { get; }
    public decimal Price { get; }
    public int Quantity { get; }

}