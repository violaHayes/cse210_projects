using System;
using System.Threading; 

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        GoalManager manager = new GoalManager(); 

        int choice;
        

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        do
        {
            manager.DisplayPlayerInfo(); 
            choice = mainMenu.ProcessMenu(); 
            
            switch (choice)
            {
                case 1: 
                    manager.CreateGoal(); 
                    break;

                case 2: 
                    manager.ListGoalDetails(); 
                    break;

                case 3: 
                    manager.SaveGoals(); 
                    break;



                case 4: 
                    manager.LoadGoals(); 
                    break;

                case 5: 
                    manager.RecordEvent(); 
                    break;

                case 6: 
                    Console.WriteLine("\nThank you for playing the Eternal Quest! Goodbye.");
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }

        }
        while (choice != 6);
    }
}