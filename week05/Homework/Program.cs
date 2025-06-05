using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(first.GetSummary());

        MathAssignment second = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(second.GetSummary());
        Console.WriteLine(second.GetHomeworkList());

        WritingAssignment third = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(third.GetSummary());
        Console.WriteLine(third.GetWritingInformation());
    }
}