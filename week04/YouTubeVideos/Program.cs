using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to cook jollof rice", "Chef Kwame", 420);
        video1.AddComment(new Comment("Ama", "Wow, this recipe is amazing!"));
        video1.AddComment(new Comment("Kojo", "Can i use basmati rice instead"));
        videos.Add(video1);

        Video video2 = new Video("Top Five Cybersecurity tips", "Allen Yates.", 200);
        video2.AddComment(new Comment("James", "Very Informative ,thanks."));
        video2.AddComment(new Comment("Kelvin", "Tip #3 was especially helpful. "));
        video2.AddComment(new Comment("John", "Please do one for bginners."));
        videos.Add(video2);

        Video video3 = new Video("Ghanna Travel Vlog 2025", "WanderVibes.", 780);
        video3.AddComment(new Comment("Kwesi", "Ghana is so beautiful."));
        video3.AddComment(new Comment("Linda", "This makes me want to visit now."));
        video3.AddComment(new Comment("Luke", "Loved the editing styles"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DidplayInfo();

            Console.WriteLine();
        }
    }
}