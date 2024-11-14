namespace Oppgaver;

public class Oppgave315I
{
    readonly Random _random = new Random();

    public void Run()
    {
        var generatedPassword = RandomPassword();
        Console.WriteLine(generatedPassword);
    }

    public string RandomPassword()
    {
        const int size = 14;
        string result = "";
        for (int i = 0; i < size; i++)
        {
            int generateChar = _random.Next(4);
            if (generateChar == 0)
                result +=  WriteRandomLowerCaseLetter(1);
            else if (generateChar == 1)
                result +=  WriteRandomUpperCaseLetter(1);
            else if (generateChar == 2)
                result += WriteRandomDigit(1);
            else if (generateChar == 3)
                result += WriteRandomSpecialCharacter(1);
        }

        return result;
    }

    public string WriteRandomSpecialCharacter(int length)
    {
        const string spesialSymbols = "!\"#\u00a4%&/(){}[]";
        string result = string.Empty;
        for (int i = 0; i < length; i++)
        {
            int randomIndex = _random.Next(0
                , spesialSymbols.Length);
            result += spesialSymbols[randomIndex];
        }

        return result;
    }

    public string WriteRandomDigit(int length)
    {
        const string numbers = "0123456789";
        string result = "";
        for (int i = 0; i < length; i++)
        {
            int index = _random.Next(numbers.Length);
            result += numbers[index];
        }

        return result;
    }

    public string WriteRandomLowerCaseLetter(int length)
    {
        const string smallChar = "abcdefghijklmnopqrstuvwxyz";
        string result = "";
        for (int i = 0; i < length; i++)
        {
            int index = _random.Next(0, smallChar.Length);
            result += smallChar[index];
        }

        return result;
    }

    public string WriteRandomUpperCaseLetter(int length)
    {
        const string bigChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string result = "";
        for (int i = 0; i < length; i++)
        {
            int index = _random.Next(0, bigChar.Length);
            result += bigChar[index];
        }

        return result;
    }
}