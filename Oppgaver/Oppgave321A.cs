namespace Oppgaver;

public class Oppgave321A
{
    public void Run()
    {
        var counter = new CharCounter();
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            counter.AddText(text);
            counter.ShowCounts();
        }
    }

    public class CharCounter
    {
        private int[] counts;

        public CharCounter()
        {
            counts = new int[250];
        }

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }

        public void ShowCounts()
        {
            for (var i = 0; i < counts.Length; i++)
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
        }
    }
}