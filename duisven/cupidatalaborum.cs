using System;

class Program
{
    static void Main()
    {
        // Example input string
        string input = "value1,value2,value3";

        // Split the string by comma
        var fk_minus_i = input.Split(',');

        // Print each value in the resulting array
        foreach (var value in fk_minus_i)
        {
            Console.WriteLine(value);
        }
    }
}
