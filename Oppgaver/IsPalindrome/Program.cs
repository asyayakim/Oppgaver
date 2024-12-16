namespace Oppgaver.IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "A dog! A panic in a pagoda!";
            var palindrome = new Palindrome(text);
            palindrome.IsPalindrome();
            
            if (palindrome.IsPalindrome())
            {
                Console.WriteLine($"Palindrome - {text} = {palindrome.ReversedText} ");
            }
            else
            {
                Console.WriteLine($"Not Palindrome - {text} != {palindrome.ReversedText}");
            }
            
            
        }
    }
}