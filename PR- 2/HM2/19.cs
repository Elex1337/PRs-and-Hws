using System;

class Program

{

    static int digitsSum(int n)

    {

        int sum = 0;

        while (n != 0)

        {

            sum += n % 10;

            n /= 10;

        }

        return sum;

    }

    static int digitsMult(int n)

    {

        int mult = 1;

        while (n != 0)

        {

            mult *= n % 10;

            n /= 10;

        }

        return mult;

    }

    static void Main()

    {

        Console.Write("Enter the number: ");

        int n = int.Parse(Console.ReadLine());


        Console.WriteLine("Sum of digits: " + digitsSum(n));

        Console.WriteLine("Mult of digits: " + digitsMult(n));


    }

}
