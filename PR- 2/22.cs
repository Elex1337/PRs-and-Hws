using System;

class Program
{
      static int  f(int x, int y) 
    {
       if (x == 0 && y == 0)
        {
            return 0;
        } else if (y == 0)
        {
            return 12/x;
        } else
        {
            return 144/(x*y);
        }

    }

    static void Main()
    {
        int x = 10;
        int y = 5;
        Console.WriteLine($"IDK " + f(x, y)); }
    }

 

