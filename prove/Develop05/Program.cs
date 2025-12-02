using System;

class Program
{
    static void Main(string[] args)
    {
      Menu mainMenu = new Menu();
        int choice;

        do
        {
            choice = mainMenu.ProcessMenu();
            switch (choice)
            {
                case 1: 
                    break;
                case 2:
                    break;
                case 3: 
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid option. Returning to menu");
                    Thread.Sleep(1500);
                    break;
            }

           
        }
        while (choice != 6);
    }
}
