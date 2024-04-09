using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Fishing", "Takashi Kido", 300);
        video1.AddComment("User1 Taro", "Your video is fun!");
        video1.AddComment("User2 Ray", "You are doing great!");
        video1.AddComment("User3 Jasmin", "Great!!");
        videos.Add(video1);

        Video video2 = new Video("Japanese 101", "Pompoko", 450);
        video2.AddComment("User4 Kaitlyn", "a little hard!");
        video2.AddComment("User5 John", "I know some words!");
        videos.Add(video2);

        // Iterate through videos
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.LengthInSeconds);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
