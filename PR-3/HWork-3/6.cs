using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символы (введите точку для завершения):");

        int spaceCount = 0;
        char inputChar;

        do
        {
            inputChar = Console.ReadKey().KeyChar;
            if (inputChar == ' ')
            {
                spaceCount++;
            }
        } while (inputChar != '.');

        Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
    }
}

