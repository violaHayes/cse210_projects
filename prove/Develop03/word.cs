using System.Runtime.CompilerServices;

class Word
{
    private string _word;

private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
  
    public bool IsHidden()
    {
        return _isHidden;

    }
    public void HideWord()
    {
        _isHidden = true;

    }
    public string GetWordString()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);

        }
        else
        {
            return _word;
        }
    }
    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }

    


}