using System;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int index = 2; 
        int elementToInsert = 10; 

        int[] newArray = InsertElement(originalArray, index, elementToInsert);

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        Console.WriteLine("\nМассив с вставленным элементом:");
        PrintArray(newArray);
    }

    static int[] InsertElement(int[] originalArray, int index, int element)
    {
        if (index < 0 || index > originalArray.Length)
        {
            throw new ArgumentOutOfRangeException("index", "Индекс находится за пределами массива.");
        }

        int[] newArray = new int[originalArray.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = originalArray[i];
        }

        newArray[index] = element;

        for (int i = index + 1; i < newArray.Length; i++)
        {
            newArray[i] = originalArray[i - 1];
        }

        return newArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

