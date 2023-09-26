using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку с прописными буквами русского алфавита:");
        string input = Console.ReadLine();

        HashSet<char> uniqueLetters = new HashSet<char>();

        foreach (char c in input)
        {
            if (char.IsUpper(c) && IsRussianLetter(c))
            {
                uniqueLetters.Add(c);
            }
        }

        int uniqueLetterCount = uniqueLetters.Count;

        Console.WriteLine($"Количество различных прописных букв русского алфавита: {uniqueLetterCount}");
    }

    static bool IsRussianLetter(char c)
    {
        return (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я');
    }
}

