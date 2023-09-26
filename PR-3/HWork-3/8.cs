using System;

class Program
{
    static void Main()
    {
        string word = "класс";
        string modifiedWord = ReplaceDuplicateLetters(word);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово с заменой: {modifiedWord}");
    }

    static string ReplaceDuplicateLetters(string word)
    {
        char[] letters = word.ToCharArray();

        if (letters.Length != 5 ||
            letters[0] != 'к' ||
            letters[1] != 'л' ||
            letters[2] != 'а' ||
            letters[3] != 'с' ||
            letters[4] != 'с')
        {
            Console.WriteLine("Слово должно быть 'класс'");
            return word;
        }

        for (int i = 0; i < letters.Length - 1; i++)
        {
            if (letters[i] == letters[i + 1])
            {
                letters[i] = '1';
                letters[i + 1] = '1';
                break; 
            }
        }

        return new string(letters);
    }
}

