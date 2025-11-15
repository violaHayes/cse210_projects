class Scripture
{
    private Reference _reference;
    private List<Word> _wordsInVerse = new List<Word>();


    public Scripture(string scripture, string reference)
    {
        _reference = ConvertToReference(reference);
        ConvertToWords(scripture);

    }

    public void Display()
    {
        _reference.Display();
        DisplayVerse();
        Console.WriteLine();
    }
    
    private void DisplayVerse()
    {
        foreach (Word word in _wordsInVerse)
        {
            Console.Write(word.GetWordString());
            Console.Write(" ");

        }
    }
    private void ConvertToWords(string scripture)
    {
        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            _wordsInVerse.Add(new Word(word));
        }
    }
    private Reference ConvertToReference(string reference)
    {
        string[] strings = reference.Split(":");
        string[] verses = strings[1].Split("-");

        int lastSpace = strings[0].LastIndexOf(" ");

        string book = strings[0].Substring(0, lastSpace);
        int chapter = int.Parse(strings[0].Substring(lastSpace+1));

        if (verses.Length == 1)
        {
            return new Reference(book, chapter, int.Parse(verses[0]));
        }
        else
        {
            return new Reference(book,chapter, int.Parse(verses[0]),int.Parse(verses[1]));
        }


    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _wordsInVerse)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public bool HideRandomWord()
    {
        if (AreAllWordsHidden())
        {
            return false;
        }
        Random rand = new Random();
        while (true)
        {
            Word word = _wordsInVerse[rand.Next(0, _wordsInVerse.Count)];
            if (!word.IsHidden())
            {
                word.HideWord();
                return true;
            }
        }


    }


}
