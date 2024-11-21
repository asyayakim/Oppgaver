namespace Oppgaver;

public class Oppgave321C
{
    public class CoinCounts
    {
        public int Count;
        public int Value;
    }

    public void Run()
    {
        Console.WriteLine("Oppgave321C");
        var coins = new List<CoinCounts>
        {
            new CoinCounts { Count = 7, Value = 1 },
            new CoinCounts { Count = 3, Value = 5 },
            new CoinCounts { Count = 2, Value = 10 },
            new CoinCounts { Count = 10, Value = 11 }
        };

        var total = CountTotal(coins);
        Console.WriteLine(total);
    }
    
    public int CountTotal(List<CoinCounts> coins)
    {
        int total = 0;
        foreach (var coin in coins)
        {
            total += coin.Value * coin.Count;
        }
        return total; 
    }
    
}