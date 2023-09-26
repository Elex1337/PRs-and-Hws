using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст из 20 символов:");
        string inputText = Console.ReadLine();

        if (inputText.Length != 20)
        {
            Console.WriteLine("Введена неверная длина строки. Пожалуйста, введите 20 символов.");
            return;
        }

        if (CheckIfCanSpellName(inputText))
        {
            Console.WriteLine("Можно составить ваше имя:");
            Console.WriteLine("Ваше имя");
        }
        else
        {
            Console.WriteLine("Нет имени");
        }
    }

    static bool CheckIfCanSpellName(string inputText)
    {
        string yourName = "Нурболат";

        foreach (char c in yourName)
        {
            if (inputText.Contains(c.ToString()))
            {
                inputText = inputText.Remove(inputText.IndexOf(c), 1);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}

