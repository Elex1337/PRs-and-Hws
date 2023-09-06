using System;
class Program
{
    public static void Main()
    {
        Console.Write("Radius ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("SideLenght ");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        double circleArea = Math.PI * Math.Pow(radius, 2);
        double squareArea = Math.Pow(sideLength, 2);
        if (circleArea > squareArea)
        {
            Console.WriteLine("Площадь круга больше ");
        }
        else if (circleArea < squareArea)
        {
            Console.WriteLine("Площадь квадрата больше");
        }
        else
        {
            Console.WriteLine("Площади равны");
        }


    }
}
