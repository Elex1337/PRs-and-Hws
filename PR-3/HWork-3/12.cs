using System;

class Program
{
    static void Main()
    {
        string text = "Это пример текста с словом one. Другие слова могут тоже присутствовать.";
        bool containsOne = CheckForWord(text, "one");

        if (containsOne)
        {
            Console.WriteLine("Текст содержит слово 'one'.");
        }
        else
        {
            Console.WriteLine("Текст не содержит слово 'one'.");
        }
    }

    static bool CheckForWord(string text, string word)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string w in words)
        {
            if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}

