namespace Oppgaver;

public class Oppgave315G
{
    public void Run()
    {
        var range = 250;
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            var counts = CountChar(text, range);
            int totalCharacters = counts.Sum();
            DisplayChar(counts, totalCharacters, range);

        }
    }

    public static int[] CountChar(string text, int range)
    {
        text = Console.ReadLine();
        int[] counts = new int[range];
        foreach (var character in text.ToLower())
        {
            counts[(int)character]++;
        }

        return counts;
    }
    
    public static void DisplayChar(int[] counts, int totalCharacters, int range)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                double persentage = (double)counts[i] / totalCharacters * 100;
                Console.WriteLine(character + " - " + counts[i] + " - " + persentage + "%");
            }
        } 
    }
}