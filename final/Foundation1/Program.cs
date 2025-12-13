using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        

        Video v1 = new Video("C# Basics", "CodeMaster", 600);
        v1.AddComment(new Comment("Jace", "Great explanation!"));
        v1.AddComment(new Comment("Jake", "Very helpful."));
        v1.AddComment(new Comment("Aaron", "Thanks!"));



        Video v2 = new Video("OOP in C#", "DevSchool", 720);
        v2.AddComment(new Comment("Dana", "Clear and simple."));
        v2.AddComment(new Comment("Larry", "Loved this!"));
        v2.AddComment(new Comment("Doug", "Nice examples."));

        Video v3 = new Video("Classes Explained", "TechWorld", 540);
        v3.AddComment(new Comment("George", "Exactly what I needed."));

        v3.AddComment(new Comment("Derek", "Good pacing."));
        v3.AddComment(new Comment("Violet", "Well done!"));

        videos.Add(v1);

        videos.Add(v2);
        videos.Add(v3);


        foreach (Video video in videos)


        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }


                Console.WriteLine();
        }
    }
}
