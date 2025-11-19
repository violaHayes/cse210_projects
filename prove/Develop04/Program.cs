using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("?"); // Replace it with the - character
        Console.Write("\b \b"); // Erase the + character
        Console.Write("^"); 
        Console.Write("\b \b"); // Erase the + character
        Console.Write("*"); 

        Console.WriteLine("Hello Develop04 World!");
    }
}