class Menu
{
    private string[] _menuStrings =
    {
        "Menu Options:",
        " 1. Start Breathing Activiy",
        " 2. Start Reflecting Activity",
        " 3. Start Listing Activity",
        " 4. Quit",
    };
    public int ProcessMenu()
    {
        int userSelection = 0;
        do
        {
            
            foreach (string meanuItem in _menuStrings)
            {
                Console.WriteLine(meanuItem);
            }
            bool success = int.TryParse(Console.ReadLine(), out userSelection);        }
        while (userSelection < 1 || userSelection > 4);
        return userSelection;


    }
}
        
    
