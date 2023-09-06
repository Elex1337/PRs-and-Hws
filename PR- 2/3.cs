using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Input centimeters");
        double centimetres = Convert.ToDouble(Console.ReadLine());
        double m = centimetres * 0.01;
        Console.WriteLine($"Metres {m}");
    }
}
