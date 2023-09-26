using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку символов:");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(' ');

        int count = 0;
        foreach (string word in words)
        {
            if (IsFirstAndLastCharEqual(word))
            {
                count++;
            }
        }

        Console.WriteLine($"Количество слов с совпадающими первым и последним символами: {count}");
    }

    static bool IsFirstAndLastCharEqual(string word)
    {
        if (word.Length >= 2 && word[0] == word[word.Length - 1])
        {
            return true;
        }

        return false;
    }
}

