using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b = ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c = ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine($"Sum {sum}");
    }
}