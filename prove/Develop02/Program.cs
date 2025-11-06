using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        journalMenu.ProcessMenu();
        int userSelection;

        bool done = false;
        do
        {





            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                /*create new entry object
                call create on that object 
                add the entry to the journal*/
                    break;
                case 2:
                /*call journal.display*/
                    break;
                case 3:
                /*save to file*/
                    break;
                case 4:
                /*read from file*/
                    break;
                case 5:
                    done = true;
                    break;

            }
        } while (!done);
    }
}