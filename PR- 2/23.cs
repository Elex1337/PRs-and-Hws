using System;

class Program
{
     static int  f(int h, int m, int s)
    {
        return h * 3600 + m * 60 + s;
    }

    static void Main()
    {
        Console.Write("Часы ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("Минуты ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Секунды ");
        int s = Convert.ToInt32(Console.ReadLine());
        int Totalsec = f(h, m, s);
        Console.WriteLine($"Прошло  " +Totalsec +" секунд");
    }
}



