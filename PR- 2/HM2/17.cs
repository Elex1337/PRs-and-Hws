using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("x");
        int x = Convert.ToInt32(Console.ReadLine());
        double y =  7 * Math.Pow(x,2) - 3*x + 4; 
        Console.WriteLine(y);
    }

}
