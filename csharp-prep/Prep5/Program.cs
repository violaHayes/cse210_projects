using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = GetUserName();
        int favNumber = GetFavoriteNumber();
        int squareNumber = SquareNumber(favNumber);
        int birthYear = GetBirthYear();

        DisplayResult(userName, squareNumber, birthYear);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int GetBirthYear()
    {
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
    }
}
