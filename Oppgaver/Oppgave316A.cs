using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace Oppgaver;

public class Oppgave316A
{
    private static readonly Random Random = new Random();

    public void Run()
    {
        var words = GetWords();
        var wordCount = 20;
        while (wordCount > 0)
        {
            var hasFoundMatch = FindWordProblem(words);
            if (hasFoundMatch) wordCount--;
        }
    }

    private static bool FindWordProblem(string[] words)
    {
        var randomWordIndex = Random.Next(words.Length);
        var selectedWord = words[randomWordIndex];
        Console.Write(selectedWord + " - ");
        foreach (var word in words)
        {
            if (!IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(selectedWord, word)) continue;
            Console.WriteLine(word);
            return true;
        }

        Console.WriteLine("<fant ikke match>");
        return false;
    }

    private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(string word1, string word2)
    {
        return IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(4, word1, word2)
               || IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(5, word1, word2);
    }

    private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(int commonLength, string word1, string word2)
    {
        var lastPartOfFirstWord = word1.Substring(word1.Length - commonLength, commonLength);
        var firstPartOfSecondWord = word2.Substring(0, commonLength);

        return lastPartOfFirstWord == firstPartOfSecondWord;
    }

    static string[] GetWords()
    {
        var lastWord = string.Empty;
        var filePath = "/Users/asyayakimova/RiderProjects/Oppgaver/Oppgaver/ordliste.txt";
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