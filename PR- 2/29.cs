using System;
using System.IO;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        using (StreamWriter sw = new StreamWriter(@"C:\Saved\протокол.txt"))
        {
            for (int i = 0; i < 100; i++)
            {
                int grade = rand.Next(2, 6); 

                switch (grade)
                {
                    case 2:
                        sw.WriteLine("Неуд");
                        break;
                    case 3:
                        sw.WriteLine("Удовл");
                        break;
                    case 4:
                        sw.WriteLine("Хор");
                        break;
                    case 5:
                        sw.WriteLine("Отл");
                        break;
                }
            }
        }

        Console.WriteLine("Программа завершена. Результаты записаны в файл протокол.txt.");
    }
}

