using System;
using System.IO; 

class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void Add(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
        }
    }
    // public static void Main(string[] args);
    public void Save()
    {
        Console.Write("Enter a filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"{entry.GetDate()}||{entry.GetPrompt()}||{entry.GetWords()}");
            }
        }
        Console.WriteLine("Your entries have been saved.");

    }
    
    public void Read()
    {
        Console.Write("Enter a filename: ");
        string filename = Console.ReadLine();
        _entryList = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(filename);
        int entryNumber = 0;
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            string date = parts[0];
            string prompt = parts[1];
            string words = parts[2];

            Entry entry = new Entry(date, prompt, words);
            _entryList.Add(entry);
            entryNumber++;
        }
        Console.WriteLine($"You've loaded {entryNumber} entries.");
    }

}