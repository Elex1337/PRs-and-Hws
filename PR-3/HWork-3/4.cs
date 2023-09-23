using System;

class Program
{

    static void Main()
    {
        string str = "halo alo balo bomba etc";
        str = string.Join(" ", str.Split().Where(x => !x.Contains('a')));
        Console.WriteLine(str);
    }
}

    


