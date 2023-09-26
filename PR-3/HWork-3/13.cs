using System;

class Program
{
    static void Main()
    {
        string inputString = "Пример строки с буквой P. Еще одна буква P здесь.";
        char targetChar = 'P';

        int count = CountOccurrences(inputString, targetChar);

        Console.WriteLine($"Количество вхождений буквы '{targetChar}' в строке: {count}");
    }

    static int CountOccurrences(string input, char target)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (Char.ToUpper(c) == Char.ToUpper(target))
            {
                count++;
            }
        }

        return count;
    }
}



