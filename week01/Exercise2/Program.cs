using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "";
        string sign = "";

        // Letter
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Sign
        if (letter == "B" || letter == "C" || letter == "D")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7) sign = "+";
            else if (lastDigit < 3) sign = "-";
        }

        else if (letter == "A" && grade < 93)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        // Phrase
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }

        else
        {
            Console.WriteLine("You didn't pass, try to study more!");
        }
    }
}