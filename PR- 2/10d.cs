using System;
class Program
{

    public static void Main()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        for (int b = Convert.ToInt32(Console.ReadLine()); b > a; a++)
        {
            Console.WriteLine(a);
        }
        }
    
   
        }
    
