using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку из 20 символов:");
        string inputString = Console.ReadLine();

        if (inputString.Length != 20)
        {
            Console.WriteLine("Введена неверная длина строки. Пожалуйста, введите 20 символов.");
            return;
        }

        int digitCount = 0;
        foreach (char c in inputString)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        Console.WriteLine($"Количество цифр в строке: {digitCount}");
    }
}

