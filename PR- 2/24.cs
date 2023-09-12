using System;

class Program
{
     static int  f(int m, int d)
    {
        return m * 30 + d ;
    }

    static void Main()
    {
        Console.Write("Месяцов ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Дней ");
        int d = Convert.ToInt32(Console.ReadLine());
        int Totaldays = f(m,d);
        Console.WriteLine($"Прошло  " +Totaldays +" дней");
    }
}



