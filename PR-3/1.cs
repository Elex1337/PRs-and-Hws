using System;
class Program
{
    static void MaxValue(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            Console.WriteLine(i);
            }
        }
    }
        
    static void Main()
    {
        int[] arr = new int[] { 2, 9, 6, 7 };
        MaxValue(arr);
    }
}
