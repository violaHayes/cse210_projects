using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "";


        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}!");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else
        {
                Console.WriteLine("You didn't pass better luck next time!"); 
        }

    
    }

}