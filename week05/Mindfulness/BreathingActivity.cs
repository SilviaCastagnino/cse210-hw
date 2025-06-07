using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;
        while (duration > 0)
        {
            Console.Write("\nBreathe in....");
            ShowCountDown(5);
            duration -= 5;
            Console.Write("\nBreathe out...");
            ShowCountDown(5);
            duration -= 5;
        }

        DisplayEndingMessage();
        ShowSpinner(7);
    }
}