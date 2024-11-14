namespace Oppgaver;

using System;
using System.Text;
using System.Security.Cryptography;

public class Oppgave315I
{
    readonly Random _random = new Random();

    public void Run()
    {
        var generatedPassword = RandomPassword();
        Console.WriteLine(generatedPassword);
        var encryptedPassword = EncryptPassword(generatedPassword, "123");
        Console.WriteLine("Encrypted Pass: " + encryptedPassword);
        var decryptedPassword = DecryptPassword(encryptedPassword, "123");
        Console.WriteLine("Decrypted Pass: " + decryptedPassword);
    }

    private static string EncryptPassword(string password, string key)
    {
        var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
        aes.IV = new byte[16];
        var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] encryptedBytes = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
        return Convert.ToBase64String(encryptedBytes);
    }

    private static string DecryptPassword(string encryptedPassword, string key)
    {
        var aes = Aes.Create();
        aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
        aes.IV = new byte[16];
        var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);
        byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
        return Encoding.UTF8.GetString(decryptedBytes);
    }

    public string RandomPassword()
    {
        const int size = 14;
        string result = "";
        for (int i = 0; i < size; i++)
        {
            int generateChar = _random.Next(4);
            if (generateChar == 0)
                result += WriteRandomLowerCaseLetter(1);
            else if (generateChar == 1)
                result += WriteRandomUpperCaseLetter(1);
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