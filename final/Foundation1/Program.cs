using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 300);
        video1.AddComment("User1", "Comment 1");
        video1.AddComment("User2", "Comment 2");
        video1.AddComment("User3", "Comment 3");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 450);
        video2.AddComment("User4", "Comment 1");
        video2.AddComment("User5", "Comment 2");
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
