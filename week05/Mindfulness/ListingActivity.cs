using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        int duration = _duration;
        while (duration > 0)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.Write("\n> ");
            stopwatch.Start();
            string input = Console.ReadLine();
            _count++;
            stopwatch.Stop();
            TimeSpan difference = stopwatch.Elapsed;
            duration -= (int)difference.TotalSeconds;
        }
        Console.WriteLine($"You have listed {_count} items.");
        DisplayEndingMessage();
        ShowSpinner(7);
    }

    public void GetRandomPrompt()
    {
        Random prompt = new Random();
        int promptNumber = prompt.Next(0, _prompts.Count());
        Console.WriteLine(_prompts[promptNumber]);
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}