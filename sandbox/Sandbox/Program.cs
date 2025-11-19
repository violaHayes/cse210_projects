// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//         string firstName;
//         string lastName;

//         Console.Write("Please enter your first name: ");
//         firstName = Console.ReadLine();

//         Console.Write("Please enter your last name: ");
//         lastName = Console.ReadLine();

//         Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}");
//     }
// }
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ello");

        string animationString = "\\|?-";
        int sleepTime = 250;
        int index = 0;
        int duration = 10;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");

        }
        int count = duration;
           while(DateTime.Now < endTime)
        {
            Console.Write(count--);            
            Thread.Sleep(1000);
            if (count >= 9)
                Console.Write("\b\b \b\b");
                else
            Console.Write("\b");

        }
    }
}
