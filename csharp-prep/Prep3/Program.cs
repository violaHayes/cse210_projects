using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;


        while (guess != magicNumber)
        {
            Console.Write("What is the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }




    }
    // static int AddValues(int n1, int n2, int n3)
    // {
    //     return n1 + n2 + n3;
    // }

    // static void TestValues(int x, float y, double z)
    // {
    //     Console.WriteLine($"The values are: {x}, {y}, {z}");
    // }

    // static void Main(string[] args)
    // {
    //     TestValues(10, (float)123, 234.234); 

    //     int total = AddValues(10, 20, 30);
    //     Console.WriteLine($"The total is: {total}");

    // {
    //     Console.WriteLine(Math.Pow(2, 64));
    //     int x = 10;
    //     Console.WriteLine($"{x}, {++x}, {x++}, {x}");

    //     for (int i = -10000; i <= 10000; i += 100)
    //     {
    //         Console.WriteLine($"The value of i is {i}");
    //     }
    //     bool done = false;
    //     while (!done)
    //     {
    //         Console.Write("Inout your age: ");
    //         int age = int.Parse(Console.ReadLine());
    //         if (age >= 0 && age <= 125)
    //         {
    //             done = true;
    //             Console.Write($"Super age: {age}");
    //         }
    //     }
    //     done = false;
    //     do
    //     {

    //         Console.Write("Inout your age: ");
    //         int age = int.Parse(Console.ReadLine());
    //         if (age >= 0 && age <= 125)
    //         {
    //             done = true;
    //             Console.Write($"Super age: {age}");
    //             while (!done);
    //         }
    //     } while (!done); // Corrected the do-while syntax here
    // }
}