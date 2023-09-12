using System;

class Program
{
  static bool even(int n)
    {
        if (n % 2 == 0) 
        { return true;
        } else
        {
            return false;
        } 
    }

    static void Main()
    {
        int n = 23;
        even(n);
        Console.WriteLine(even(n));
    }
}



