using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Journal journal= new Journal();
        Menu journalMenu = new Menu();
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
                    Entry entry = new Entry();
                    entry.AddResponse();
                    journal.Add(entry);
                    break;
                case 2:
                    /*call journal.display*/
                    journal.Display();
                    break;
                case 3:
                    /*save to file*/
                    journal.Save();
                    break;
                case 4:
                    /*read from file*/
                    journal.Read();
                    break;
                case 5:
                    done = true;
                    break;

            }
        } while (!done);
    }
}