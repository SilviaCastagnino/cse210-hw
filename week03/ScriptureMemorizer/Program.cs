using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all your heart and do not lean on your own understanding.");

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or 'quit' to exit");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") return;

            scripture.HideRandomWords(3);
        }
        while (!scripture.IsCompletelyHidden());

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program finished.");
    }
}