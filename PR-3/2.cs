using System;

class Program
{

    static void Main()
    {
        int[] M = { 1, 2, 3, 4, 5 };
        int[] N = { 3, 4, 5, 6, 7 };
        List<int> result = new List<int>();

        for (int i = 0; i < M.Length; i++)
        {
            for (int j = 0; j < N.Length; j++)
            {
                if (M[i] == N[j] && !result.Contains(M[i]))
                {
                    result.Add(M[i]);
                    break; 
                }
            }
        }
        foreach (int element in result)
        {
            Console.WriteLine(element);
        }
    }
}
