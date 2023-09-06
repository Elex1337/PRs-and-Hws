using System;
class Program
{
    public static void Main()
    {
        Console.Write("Напряжение 1");
        double u1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Напряжение 2");
        double u2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("сопротивление 1");
        double r1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("сопротивление 2");
        double r2 = Convert.ToDouble(Console.ReadLine());
        double i1 = u1 / r1;
        double i2 = u2 / r2;
        if  (i1 > i2)
        {
            Console.WriteLine("Меньший ток протекает через второй участок ");
        } else if (i1 < i2)
        {
            Console.WriteLine("Меньший ток протекает через первый участок ");
        }
        else
        {
            Console.WriteLine("Токи равны ");
        }
    }
}

