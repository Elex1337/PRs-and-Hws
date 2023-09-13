using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = Convert.ToInt32(Console.ReadLine());


        Console.Write("Введите значение B: ");
        int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }


