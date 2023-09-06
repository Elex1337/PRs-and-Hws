using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Days ");
        int days = Convert.ToInt32(Console.ReadLine());
        int weeks = days / 7;
        Console.WriteLine(weeks);
    }
}
