namespace Oppgaver;

public class Oppgave321C
{
    public class Coin
    {
        public int Count { get; internal set; }
        public int Value { get; internal set; }

        public int TotalValue()
        {
            return Count * Value;
        }
    }

    public void Run()
    {
        Console.WriteLine("Oppgave321C");
        var coins = new List<Coin>
        {
            new Coin { Count = 7, Value = 1 },
            new Coin { Count = 3, Value = 5 },
            new Coin { Count = 2, Value = 10 },
            new Coin { Count = 10, Value = 11 }
        };

        var total = CountTotal(coins);
        Console.WriteLine(total);
    }

    public static int CountTotal(List<Coin> coins)
    {
        int total = 0;
        foreach (var coin in coins)
        {
            total += coin.TotalValue();
        }
        return total;
    }
}