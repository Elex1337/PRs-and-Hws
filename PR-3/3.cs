using System;
using System.Diagnostics.Tracing;

class Program
{
 static bool Check_Polyndrom(string str)
    {
       for (int i = 0; i < str.Length/2; i++) {
        if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }
        return true;

    }
    static void Main()
    {
        string str = "idxc";
     if (Check_Polyndrom(str))
        {
            Console.WriteLine("Polyndrom");
        }
     else
        {
            Console.WriteLine("Incorrect ");
        }
    }
}

