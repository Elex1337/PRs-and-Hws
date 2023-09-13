using System;

class Program
{
    public static void Main(string[] args)
    {
        int year = 5;
        int month = 10;
        int day = 5;
        int nextDay = (year*365+30*10+day*1) + 1;
        int lastDay = (year * 365 + 30 * 10 + day * 1) - 1;
        Console.WriteLine($"Next day {nextDay} last day {lastDay}");
    }

} 
