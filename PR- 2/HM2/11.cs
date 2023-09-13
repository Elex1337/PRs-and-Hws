using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = 75;
        int a = n / 10;
        int b = n % 10;
        if (a > b)
        {
            Console.WriteLine("Первая больше");
        }
        else if (a < b) {
            Console.WriteLine("Вторая больше ");
        }
        else
        {
            Console.WriteLine("Равны ");
        }
    }

} 
