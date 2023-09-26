using System;

class Program
{
    
    static void showArr(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void fillArr(int[,] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = rnd.Next(-100, 100);
            }
        }
    }
            static void Main()
    {
        int[,] a = new int[5, 5];
        fillArr(a);
        showArr(a);

        int min = a[0, 0];
        int max = a[0, 0];
        int minI = 0, minJ = 0, maxI = 0, maxJ = 0;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < min)
                {
                    min = a[i, j];
                    minI = i;
                    minJ = j;
                }
                if (a[i, j] > max)
                {
                    max = a[i, j];
                    maxI = i;
                    maxJ = j;
                }
            }
        }

        int sum = 0;
        for (int i = Math.Min(minI, maxI) + 1; i < Math.Max(minI, maxI); i++)
        {
            for (int j = Math.Min(minJ, maxJ) + 1; j < Math.Max(minJ, maxJ); j++)
            {
                sum += a[i, j];
            }
        }


        Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");
    }
}


