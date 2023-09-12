using System;

class Program
{
     static void  f(ref int a,ref int b, int x, int y) 
    {
        a = x * y;
        b = x / y;
    }

    static void Main( )
    {
        int resultA = 0;
        int resultB = 0;
        int x = 10;
        int y = 5;
        f(ref resultA,ref resultB,  x,   y);
        Console.WriteLine($"  x/y = {resultA}, x*y = {resultB}");
    }
}
 
