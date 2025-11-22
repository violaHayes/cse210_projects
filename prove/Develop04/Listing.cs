using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        StartMessage();
        
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"{_prompts[promptIndex]}");

        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        Console.WriteLine("Start listing items now (press Enter after each item):");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int itemCount = 0;
        
        while (DateTime.Now < endTime)
        {
    
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                itemCount++;
            }
            
            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        Console.WriteLine($"You listed {itemCount} items!");
        Console.WriteLine();

        EndMessage();
    }
}