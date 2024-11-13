namespace Oppgaver;

public class Oppgave315G
{
    public void Run()
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            foreach (var character in text.ToLower())
            {
                counts[(int)character]++;
            }
            int totalCharacters = counts.Sum();
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
}