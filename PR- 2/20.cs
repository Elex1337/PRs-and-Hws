using System;

class Program
{
     static void Swap(ref int a, ref int b) //не понял 20 задачу
    {
        int equals = a;
        a = b;
        b = equals;
    }

    static void Main( )
    {
        int x = 5;
        int y = 10;
        Console.WriteLine($"До: x = {x}, y = {y}");
         Swap(ref x, ref y);
        Console.WriteLine($"После: x = {x}, y = {y}");
    }
}
 
