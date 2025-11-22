using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        StartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            if (DateTime.Now < endTime)
            {
                int cursorLeft = Console.CursorLeft;
                int cursorTop = Console.CursorTop;

                Console.Write("Breathe in...");
                ShowCountdown(4);

                Console.SetCursorPosition(cursorLeft, cursorTop); 
                
                Console.Write("                "); 
                
                Console.SetCursorPosition(cursorLeft, cursorTop);
            }

            if (DateTime.Now < endTime)
            {
                int cursorLeft = Console.CursorLeft;
                int cursorTop = Console.CursorTop;

                Console.Write("Breathe out...");
                ShowCountdown(6);

                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.Write("                 "); 
                Console.SetCursorPosition(cursorLeft, cursorTop); 
            }
            Console.WriteLine();
        }

        EndMessage();
    }
}