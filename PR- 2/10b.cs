using System;
class Program
{

    public static void Main()
    {
        Console.Write("input ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 10; i < a; i++)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
        }
    
   
        }
