using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int user_input = 1;
        while (user_input != 0)
        {
            Console.Write("Enter number: ");
            string user_input_string = Console.ReadLine();
            user_input = int.Parse(user_input_string);
            numbers.Add(user_input);
        }

        int sum = 0;
        int count = numbers.Count;

        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = numbers.Average();
        int largest = numbers.Max();



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}