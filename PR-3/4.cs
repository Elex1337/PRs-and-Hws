using System;

class Program
{


    static void Main()
    
    {
        Console.WriteLine("Enter ");
        string str = Console.ReadLine();
        string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int wordsout = words.Length;
        Console.WriteLine($"Количество слов в предложении: {wordsout}");

    }

}




