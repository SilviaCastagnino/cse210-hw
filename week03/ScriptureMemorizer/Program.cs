/*To exceed the requirements and show creativity I added a list of scriptures. The program will choose random scripture from the list.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."));
        scriptures.Add(new Scripture(new Reference("Psalm", 24, 3, 4), "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully."));
        scriptures.Add(new Scripture(new Reference("John", 7, 17), "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself."));

        Random random = new Random();
        int randomScripture = random.Next(0, scriptures.Count());

        do
        {
            Console.Clear();
            Console.WriteLine(scriptures[randomScripture].GetReference().GetDisplayText() + " " + scriptures[randomScripture].GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or 'quit' to exit");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") return;

            scriptures[randomScripture].HideRandomWords(3);
        }
        while (!scriptures[randomScripture].IsCompletelyHidden());

        Console.Clear();
        Console.WriteLine(scriptures[randomScripture].GetReference().GetDisplayText() + " " + scriptures[randomScripture].GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program finished.");
    }
}