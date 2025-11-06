
class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to the Journal",
        "You can create display save and read journal entries",
        "1 - Create a Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to File",
        "4 - Read Journal from file",
        "5 - Quit"

/* Process Menu will display menu to user and read and validate the input and return the input*/
/*There are no parameters recieved in this function*/
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
            userSelection = int.Parse(Console.ReadLine());
        }
        while (userSelection < 1 || userSelection > 5);
        return userSelection;


    }
}