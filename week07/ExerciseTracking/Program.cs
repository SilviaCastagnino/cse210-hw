using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 06, 17), 30, 3.0),
            new Cycling(new DateTime(2025, 06, 17), 30, 9.7),
            new Swimming(new DateTime(2025, 06, 17), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}