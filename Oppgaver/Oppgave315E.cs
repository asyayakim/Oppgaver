namespace Oppgaver;

public class Oppgave315E
{
    public void Run()
    {
        Console.WriteLine("Returning of the numbers");
        int startNumer = 1000;
        int endNumer = 1028;
        Console.ReadLine();
        string result = ReturnString(startNumer, endNumer);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static string ReturnString(int startNumer, int endNumer)
    {
        List<int> numbers = new List<int>();
        while (startNumer <= endNumer)
        {
            numbers.Add(startNumer);
            startNumer += 7;
        }

        return string.Join(" ", numbers);
        
    }
}