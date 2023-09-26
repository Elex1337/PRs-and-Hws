using System;

class Program
{


    static void Main()
    
    {
        Console.WriteLine("Enter ");
        string str = Console.ReadLine();
        char currentChar = str[0];
        int currentCount = 1;
        int maxCount = 1;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == currentChar)
            {
                currentCount++;
            }
            else
            {
                currentChar = str[i];
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
        }
        Console.WriteLine(maxCount);

    }

}





