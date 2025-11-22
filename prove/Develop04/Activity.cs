using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int duration) && duration > 0)
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid duration. Setting to default 30 seconds.");
            _duration = 30;
        }

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5); 
    }

    protected void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3); 

        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(5); 
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(250); 
            
            Console.Write("\b \b"); 

            i++;
            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        // Save the starting cursor position before any output
        int startLeft = Console.CursorLeft;
        int startTop = Console.CursorTop;

        for (int i = seconds; i > 0; i--)
        {
            // Write the number
            Console.Write(i);
            
            // Pause for one second
            Thread.Sleep(1000); 

            // Clear the number:
            
            // Move the cursor back to the starting position for the number
            Console.SetCursorPosition(startLeft, startTop);
            
            // Write spaces to cover the number (handles 1-9 and 10+ cleanly)
            Console.Write("  "); 
            
            // Move the cursor back to the starting position for the next number (or end of method)
            Console.SetCursorPosition(startLeft, startTop);
        }
    }

    public virtual void RunActivity()
    {
        
    }
}