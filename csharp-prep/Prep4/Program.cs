using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if (userNumber != 0)
            {
                ints.Add(userNumber);
            }

        }
        int sum = 0;
        foreach (int number in ints)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = (float)sum / ints.Count;
        Console.WriteLine($"The average of the numbers is :{average} ");
        int max = ints[0];
        foreach (int number in ints)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is:{max} ");
        
        
        

    }
}