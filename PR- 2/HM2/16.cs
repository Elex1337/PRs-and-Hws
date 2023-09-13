using System;

class Program
{
    static void Main()
    {
        double distanceInKilometers = 10; 
        double distanceInFeet = 32808.4; 

        double feetToKilometers = 0.000305; 

        double distanceInKilometersFromFeet = distanceInFeet * feetToKilometers;

        if (distanceInKilometers < distanceInKilometersFromFeet)
        {
            Console.WriteLine("Расстояние в километрах меньше.");
        }
        else if (distanceInKilometers > distanceInKilometersFromFeet)
        {
            Console.WriteLine("Расстояние в футах меньше.");
        }
        else
        {
            Console.WriteLine("Расстояния равны.");
        }
    }
}

