using System;

class Program
{
    public static void Main(string[] args)
    {
        bool A= true;
        bool B = false;
        bool C = false;
        Console.WriteLine( !A & B);
        Console.WriteLine(A | !B );
        Console.WriteLine(A & B | C);
    }
}
