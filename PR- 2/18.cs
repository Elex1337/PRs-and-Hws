using System;

class Program

{

    public static void Main()
    {
        bool x = true;
        bool y = false;
        Console.WriteLine(!x & !y);
        Console.WriteLine(x | (!x & y));
        Console.WriteLine((!x & y) | y);
    }
}
