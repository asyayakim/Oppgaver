namespace Oppgaver.TestProject;

public class Program
{
    static void Main(string[] args)
    {
        // string text = "Den lille katten sov søtt på den gamle, slitte sofaen.";
        // TextAnalyzer analyzer = new TextAnalyzer(text);
        // Console.WriteLine($"Total characters: {analyzer.CountCharacters()}");
        // Console.WriteLine($"Total spaces: {analyzer.CountSpaces()}");
        // Console.WriteLine($"Total special characters: {analyzer.CountSpecialCharacters()}");
        // Console.WriteLine($"Total vowels: {analyzer.CountVowels()}");
        // Console.WriteLine($"Is palindrome: {analyzer.IsPalindrome()}");
        // Console.WriteLine($"Change symbols: {analyzer.ChangeSymbols()}");
        Random random = new Random();
        Numbers numbers = new Numbers(random);
        numbers.CreateFunction();
    }
}