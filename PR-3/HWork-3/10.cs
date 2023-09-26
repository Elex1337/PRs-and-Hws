using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int reversedNumber = ReverseNumber(N);

        Console.WriteLine("Число, прочитанное справа налево: " + reversedNumber);
    }

    static int ReverseNumber(int num)
    {
        int reversedNum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }

        return reversedNum;
    }
}
