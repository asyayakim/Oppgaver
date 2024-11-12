namespace Oppgaver;

public class Oppgave315C
{
    public void Run()

    {
        Console.WriteLine("Oppgave315C");
        Console.WriteLine("Type a text here to see the results. ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed text " + reversed);
        int countWord = CountWord(input);
        Console.WriteLine("Total words " + countWord);
    }

    public static string ReverseString(string input)
    {
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        return reversed;
    }
    public static int CountWord(string input)
    {
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    
}