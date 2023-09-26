using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите маленькую русскую букву:");
        char smallLetter = Console.ReadKey().KeyChar;

        if (char.IsLower(smallLetter) && smallLetter >= 'а' && smallLetter <= 'я')
        {
            char capitalLetter = (char)(smallLetter - ('а' - 'А'));
            Console.WriteLine($"\nСоответствующая большая буква: {capitalLetter}");
        }
        else
        {
            Console.WriteLine("\nЭто не маленькая русская буква.");
        }
    }
}

