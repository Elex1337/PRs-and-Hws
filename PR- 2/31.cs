using System;

class Program
{
    static int f(int N, int n)
    {
        int result = N;
        while (result % n != 0)
        {
            result++;
        }
        return result;
    }


    static void Main()
    {
        int n = 3;
        int N = 25;
        int result = f(N,n);
        Console.WriteLine($"Наименьшее число, большее или равное {N}, которое делится нацело на {n}, равно {result}");
    }
}


