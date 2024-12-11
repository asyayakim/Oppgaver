using System.Text.RegularExpressions;
using RandomBoxes;

namespace Oppgaver.TestProject
{
    internal partial class TextAnalyzer
    {
        private string _replace;

        public TextAnalyzer(string text)
        {
            _text = text;
        }

        public string _text { get; set; }


        public string CountCharacters()
        {
            return _text.Length.ToString();
        }

        public string CountSpaces()
        {
            var count = 0;
            for (int i = 0; i < _text.Length; i++)
            {
                if (char.IsWhiteSpace(_text[i]))
                {
                    count++;
                }
            }

            return count.ToString();
        }

        public string CountSpecialCharacters()
        {
            var count = 0;
            var specialCharacters = ",.';[]";
            for (int i = 0; i < _text.Length; i++)
            {
                if (specialCharacters.Contains(_text[i]))
                {
                    count++;
                }
            }

            return count.ToString();
        }

        public string CountVowels()
        {
            var count = 0;
            var vowels = "aeiou";
            for (int i = 0; i < _text.Length; i++)
                if (vowels.Contains(_text[i]))
                {
                    count++;
                }

            return count.ToString();
        }

        public string IsPalindrome()
        {
            bool isPalindrome = _text.Reverse() == _text;
            return isPalindrome.ToString();
        }

        public string ChangeSymbols()
        {
            _replace = _text.Replace(" ", "_");
            return _replace;
        }
    }
    // public virtual void BasicTextLoop(string text)
    //     {
    //         _count = 0;
    //         for (int i = 0; i < _text.Length; i++)
    //         {
    //             _count++;
    //         }
    //         Console.WriteLine(_feedbackText);
    //     }
    //     public void HowLongTheText(string s)
    //     {
    //         _count = 0;
    //         for (int i = 0; i < _text.Length; i++)
    //         {
    //             _count++;
    //         }
    //         Console.WriteLine("Total letters - " + _count;);
    //     }
    //     public void HowManySpace(string text)
    //     {
    //         _count = 0;
    //         var space = " ";
    //         for (int i = 0; i < text.Length; i++)
    //         {
    //             if (text[i] == ' ')
    //             {
    //                 _count++;
    //             }
    //         } 
    //         _feedbackText = "Total space - " + _count;
    //         Console.WriteLine(_feedbackText);
    //     }
    //     public void HowManySpesialLetters(string text)
    //     {
    //         _count = 0;
    //         var textWithoutSpaces = text.Trim();
    //         var specialChars = "!@#$%^&*()_+{}[]<>|,.";
    //         for (int i = 0; i < textWithoutSpaces.Length; i++)
    //         { 
    //             char letter = textWithoutSpaces[i];
    //             if (specialChars.Contains(letter))
    //             {
    //                 _count++;
    //             }
    //         }
    //         _feedbackText = "Total special letters - " + _count;
    //         Console.WriteLine(_feedbackText);
    //     }
}