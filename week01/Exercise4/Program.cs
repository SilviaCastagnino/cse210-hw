using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largerNumber = 0;
        foreach (int i in numbers)
        {
            if (i > largerNumber)
            {
                largerNumber = i;
            }
        }
        Console.WriteLine($"The larger number is: {largerNumber}");

        int smallestPositive = 0;
        foreach (int i in numbers)
        {
            if (i > 0)
            {
                if (smallestPositive == 0 || i < smallestPositive)
                {
                    smallestPositive = i;
                }
            }
        }
        if (smallestPositive != 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}