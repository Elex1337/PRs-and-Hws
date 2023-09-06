using System;
class Program
{

    public static void Main()
    {
        Console.Write("Введите радиус круга ");
        double r = Convert.ToDouble(Console.ReadLine());
        double l = 2 * Math.PI * r;
        double S = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"Длина окружности круга {l}");
        Console.WriteLine($"Площадь круга {S}");
    }
}
    
