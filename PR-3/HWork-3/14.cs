using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();
        string[] words = Regex.Split(inputText, @"\W+");

        Dictionary<char, int> startingLetterCount = new Dictionary<char, int>();

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                char firstLetter = char.ToUpper(word[0]); 
                if (Char.IsLetter(firstLetter))
                {
                    if (startingLetterCount.ContainsKey(firstLetter))
                    {
                        startingLetterCount[firstLetter]++;
                    }
                    else
                    {
                        startingLetterCount[firstLetter] = 1;
                    }
                }
            }
        }

        if (startingLetterCount.Count > 0)
        {
            char mostCommonLetter = startingLetterCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int count = startingLetterCount[mostCommonLetter];

            Console.WriteLine($"Наиболее часто встречающаяся начальная буква: {mostCommonLetter}, количество слов: {count}");
        }
        else
        {
            Console.WriteLine("В тексте нет слов.");
        }
    }
}

