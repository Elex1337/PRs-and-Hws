using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 2)
        {
            Console.WriteLine("Недостаточно слов для выполнения задачи.");
            return;
        }

        string lastWord = words[words.Length - 1].ToLower();

        string result = "";
        foreach (string word in words)
        {
            if (!ContainsAnyLetterFromWord(word.ToLower(), lastWord))
            {
                result += word + " ";
            }
        }

        Console.WriteLine("Результат:");
        Console.WriteLine(result.Trim());
    }

    static bool ContainsAnyLetterFromWord(string word, string referenceWord)
    {
        foreach (char c in referenceWord)
        {
            if (word.Contains(c))
            {
                return true;
            }
        }
        return false;
    }
}

