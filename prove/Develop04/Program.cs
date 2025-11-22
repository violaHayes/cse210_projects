using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        int choice;

        do
        {
            choice = mainMenu.ProcessMenu();
            Activity currentActivity = null;

            switch (choice)
            {
                case 1: 
                    currentActivity = new BreathingActivity();
                    break;
                case 2:
                    currentActivity = new ReflectionActivity();
                    break;
                case 3: 
                    currentActivity = new ListingActivity(); 
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Returning to menu");
                    Thread.Sleep(1500);
                    break;
            }

            if (currentActivity != null)
            {
                currentActivity.RunActivity();
            } 
        }
        while (choice != 4);
    }
}
