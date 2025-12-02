class Menu
{
    private string[] _menuStrings =
    {
        "Welcome to the Goal Activity:",
        " 1. Create New Goal",
        " 2. List Goals",
        " 3. Save Goals",
        " 4. Load Goals",
        " 5. Record Event",
        " 6. Quit",
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
            bool success = int.TryParse(Console.ReadLine(), out userSelection); }



        while (userSelection < 1 || userSelection > 6);
        return userSelection;
    }
}
        
    
