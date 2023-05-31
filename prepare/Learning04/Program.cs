using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignemtn = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignemtn.GetSummary());
        Console.WriteLine(mathAssignemtn.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetTitle());
    }
}