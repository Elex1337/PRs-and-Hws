using System;
class Program
{
    static void DeleteFromArray(int[] arr)
    {
        int numofindex = 0;
        int[] deleteindx = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != numofindex)
            {
                deleteindx[j++] = arr[i];
                Console.WriteLine(arr[i]);
            }
        }
    }
        
    static void Main()
    {
        int[] arr = new int[] { 2, 9, 6, 7 };
        DeleteFromArray(arr);
    }
}
