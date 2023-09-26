using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");

        string inputText = Console.ReadLine();
        string convertedText = ConvertCase(inputText);

        Console.WriteLine("Преобразованный текст:");
        Console.WriteLine(convertedText);
    }

    static string ConvertCase(string text)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            else if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }
}

