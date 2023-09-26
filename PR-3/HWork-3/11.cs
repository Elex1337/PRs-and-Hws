using System;

class Program
{
    static void Main()
    {
        string inputString = "Это/тест\\удаления/слэшей\\";
        string modifiedString = RemoveSlashes(inputString);

        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка после удаления слэшей: " + modifiedString);
    }

    static string RemoveSlashes(string input)
    {
        string result = input.Replace("/", "").Replace("\\", "");
        return result;
    }
}

