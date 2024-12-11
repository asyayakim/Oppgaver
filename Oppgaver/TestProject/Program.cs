using System.Net.Sockets;
using Oppgaver.ClassStructure;

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
        // Random random = new Random();
        // Numbers numbers = new Numbers(random);
        // numbers.CreateFunction();
        // int[] array = {1,23,2343,433, 656,67,457};
        // ArrayCount numbers = new ArrayCount();
        // Console.WriteLine(numbers.BiggestNumber(array));
        // Console.WriteLine(numbers.SmallesrNumber(array));
        // Console.WriteLine(numbers.ReverseNumber(array));
        // Console.WriteLine(numbers.Sum(array));
        List<StudentInClass> students = new List<StudentInClass>
        {
            new StudentInClass("Alice", 1, 26),
            new StudentInClass("Bob", 2, 22),
        };
       students.Add(new StudentInClass("Alex", 3, 20));
       foreach (var student in students)
       {
           student.DisplayInfo();
           student.FindYoungest(students);
       }
    }
}
