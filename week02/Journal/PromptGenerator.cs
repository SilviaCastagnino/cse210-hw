using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most challenging thing I faced today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "How am I truly feeling right now, and why?",
        "Did I learn anything new? What was it?",
        "What's a goal I have for tomorrow?",
        "Who did I talk to today, and what did I talk about?",
        "What made me laugh or smile?",
        "What's one thing I'am looking forward to?",
        "If I could change one thing about today, what would it be?",
        "What's a small act of kindness I witnessed or performed?",
        "What's something I'm proud of?",
        "What is my most important goal right now?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
}