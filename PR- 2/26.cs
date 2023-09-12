using System;

class Program
{
  static int f(int m1, int m2 , int m3 )
    {
        if (m1 <= m2 && m1 <= m3)
        {
            return m1;
        }
        else if (m2 <= m1 && m2 <= m3)
        {
            return m2;
        }
        else
        {
            return m3;
        }
    }

    static void Main()
    {
        Console.Write("m1 ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("m2 ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("m3 ");
        int m3 = Convert.ToInt32(Console.ReadLine());
        int min = f(m1, m2, m3);
        Console.WriteLine($"Меньшее " +min);
    }
}

