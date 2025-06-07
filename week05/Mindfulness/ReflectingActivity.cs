using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string listener = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        int duration = _duration;
        while (duration > 0)
        {
            DisplayQuestions();
            ShowSpinner(10);
            duration -= 10;
        }

        DisplayEndingMessage();

        ShowSpinner(7);
    }

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int promptNumber = prompt.Next(0, _prompts.Count());
        return _prompts[promptNumber];
    }

    public string GetRandomQuestion()
    {
        Random question = new Random();
        int questionNumber = question.Next(0, _questions.Count());
        _questions.RemoveAt(questionNumber);
        return _questions[questionNumber];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}