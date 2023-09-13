using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
        string input = Console.ReadLine();

        if (input.Length == 6 && int.TryParse(input, out int ticketNumber))
        {
            int firstHalfSum = 0;
            int secondHalfSum = 0;
for (int i = 0; i < 6; i++)
         {
                int digit = ticketNumber % 10;
                ticketNumber /= 10;

             if (i < 3)
                 firstHalfSum += digit;
            else
             secondHalfSum += digit;
            }

            if (firstHalfSum == secondHalfSum)
            {
                Console.WriteLine("У вас счастливый билет!");
            }
            else
            {
                Console.WriteLine("К сожалению, это не счастливый билет.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите 6-значное число.");
        }
    }
}
