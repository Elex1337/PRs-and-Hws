using System;

class Program
{
  static int f(int M, int N)
    {
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        return sum;
    }


    static void Main()
    {
        int M = 5;
        int N = 25;
        int result = f(M, N);
        Console.WriteLine($"Сумма нечетных чисел от {M} до {N} равна {result}");
    }
}

