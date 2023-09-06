using System;
class Program
{
    public static void Main()
    {
        Console.Write("Масса первого материала ");
        double m1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Масса второго материала ");
        double m2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Обьем первого материала ");
        double v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Обьем второго материала ");
        double v2 = Convert.ToDouble(Console.ReadLine());
        double p1 = m1/v1;
        double p2 = m2/v2;
        if  (p1 > p2)
        {
            Console.WriteLine("Первый материал имеет большую плотность ");
        } else if (p1 < p2)
        {
            Console.WriteLine("Второй материал имеет большую плотность ");
        }
        else
        {
            Console.WriteLine("Плотность равна ");
        }
    }
}

