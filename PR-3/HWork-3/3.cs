using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int[] RemoveTwiceOccurring(int[] arr)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        foreach (int element in arr)
        {
            if (frequencies.ContainsKey(element))
            {
                frequencies[element]++;
            }
            else
            {
                frequencies[element] = 1;
            }
        }

        List<int> newArray = arr.Where(element => frequencies[element] != 2).ToList();
        return newArray.ToArray();
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 3, 4 };
        int[] newArray = RemoveTwiceOccurring(array);

        Console.WriteLine(string.Join(", ", newArray));
    }
}
