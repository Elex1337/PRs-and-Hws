using System;

class Program
{
    static void Main()
    {
        int[] A = new int[5];

        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < 5; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        double[,] B = new double[3, 4];
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.NextDouble() * 10;
            }
        }

        Console.Write("Массив A: ");
        foreach (int element in A)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        int maxA = A[0], minA = A[0];
        double maxB = B[0, 0], minB = B[0, 0];
        double sumA = 0, sumB = 0, productA = 1, productB = 1;

        foreach (int element in A)
        {
            if (element > maxA) maxA = element;
            if (element < minA) minA = element;
            sumA += element;
            productA *= element;
        }

        foreach (double element in B)
        {
            if (element > maxB) maxB = element;
            if (element < minB) minB = element;
            sumB += element;
            productB *= element;
        }

        Console.WriteLine("\nРезультаты:");
        Console.WriteLine($"Максимальный элемент в массиве A: {maxA}");
        Console.WriteLine($"Минимальный элемент в массиве A: {minA}");
        Console.WriteLine($"Максимальный элемент в массиве B: {maxB}");
        Console.WriteLine($"Минимальный элемент в массиве B: {minB}");
        Console.WriteLine($"Сумма всех элементов в массиве A: {sumA}");
        Console.WriteLine($"Сумма всех элементов в массиве B: {sumB}");
        Console.WriteLine($"Произведение всех элементов в массиве A: {productA}");
        Console.WriteLine($"Произведение всех элементов в массиве B: {productB}");
    }
}





