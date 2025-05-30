using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("How to increase your memory power today", "Jim Kwik", 4200));
        videos.Add(new Video("The first 20 hours -- how to learn anything", "Josh Kaufman", 1200));
        videos.Add(new Video("DALI KOUMBÈ: inside the village of the tribe without eyes", "Project Happiness", 1500));

        Comment comment = new Comment("Marco Rossi", "This video was so helpful");
        videos[0].AddComment(comment);

        comment = new Comment("Jennifer Deep", "It worked with me");
        videos[0].AddComment(comment);

        comment = new Comment("Johnny White", "You are amazing Jim");
        videos[0].AddComment(comment);

        comment = new Comment("James New", "I did it, I learned Hukulele");
        videos[1].AddComment(comment);

        comment = new Comment("Charlie Lopez", "I will try, let see if it works");
        videos[1].AddComment(comment);

        comment = new Comment("Alexa Potter", "I read the book about it");
        videos[1].AddComment(comment);

        comment = new Comment("Harry McDonald", "Wow I can't believe there are these kind of things");
        videos[2].AddComment(comment);

        comment = new Comment("Homer Arnold", "You are doing something that everybody want to do it");
        videos[2].AddComment(comment);

        comment = new Comment("Sasha Baer", "Your videos are better than any documentary");
        videos[2].AddComment(comment);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideo());
            Console.WriteLine("Total comments: " + video.GetNumberComments());
            Console.WriteLine(video.DisplayComments());
        }
    }
}