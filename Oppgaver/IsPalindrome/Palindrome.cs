namespace Oppgaver.IsPalindrome
{
    public class Palindrome
    {
        private readonly string _text;
        public string ReversedText { get; private set; }

        public Palindrome(string text)
        {
            _text = text;
        }

        public bool IsPalindrome()
        {
            var cleanText = CleanText();

            ReversedText = new string(cleanText.Reverse().ToArray());
            if (ReversedText.Equals(cleanText))
                return true;
            return false;
        }

        private string CleanText()
        {
            var cleanText = "";
            foreach (var character in _text)
            {
                if (char.IsLetter(character))
                {
                    cleanText += character;
                }
            }
            return cleanText.ToLower();
        }
    }
}