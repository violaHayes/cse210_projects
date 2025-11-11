class Entry
{
    public string _words;
    public string _date;
    public string _prompt;

    public Entry()
    {
        _date = DateTime.Now.ToString("dd/MM/yyyy");
        _prompt = "";
        _words = "";
        
    }
    public Entry(string date, string prompt, string words)
    {
        _words = words;
        _date = date;
        _prompt = prompt;
    }
    public void AddResponse()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.GetPrompt();


        Console.WriteLine(_prompt);
        _words = Console.ReadLine();

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt}");
        Console.WriteLine(_words);
    }

    public string GetWords()
    {
        return _words;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    
    
}