using System.Text;

namespace Oppgaver;

public class Oppgave316A2
{
    private readonly Random Random = new Random();
    public void Run()
    {
        string[] words = FindWords();
        var wordCounter = 20;
        while (0 < wordCounter)
        {
            var matchingWords = FindCorrect (words);
            if (Convert.ToBoolean(matchingWords)) wordCounter--;
        }
    }

    public bool FindCorrect(string[] words)
    {
        var randomWordIndex = Random.Next(words.Length);
        var selectedWord = words[randomWordIndex];
        Console.Write(selectedWord + " - ");
        foreach (var word in words)
        {
            if (!IsSuffixEqualToPreffix(selectedWord, word)) continue;
            Console.WriteLine(word);
            return true;
        }
        Console.WriteLine("No match");
        return false;
    }

    private bool IsSuffixEqualToPreffix(string word1, string word2)
    {
        return IsSuffixEqualToPreffix(4, word1, word2)
               || IsSuffixEqualToPreffix(5, word1, word2);
    }

    private bool IsSuffixEqualToPreffix(int commonLength, string word1, string word2)
    {
        var lastPartOfFirstWord = word1.Substring(word1.Length - commonLength, commonLength);
        var firstPartOfSecondWord = word2.Substring(0, commonLength);
        return lastPartOfFirstWord == firstPartOfSecondWord;
    }

    public string[] FindWords()
    {
        var lastWord = string.Empty;
        var filePath = "/Users/asyayakimova/RiderProjects/Oppgaver/Oppgaver/ordliste.txt";
        if (filePath == null) throw new ArgumentNullException(nameof(filePath));
        var wordList = new List<string>();
        foreach (var line in File.ReadLines(filePath, Encoding.UTF8))
        {
            var parts = line.Split('\t');
            var word = parts[1];
            if (word != lastWord
                && word.Length > 6
                && word.Length < 10
                && !word.Contains("-"))
            {
                wordList.Add(word);
            }
            lastWord = word;
        }
        return wordList.ToArray();
    }
}