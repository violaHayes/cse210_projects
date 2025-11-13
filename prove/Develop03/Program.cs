using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
        Console.WriteLine(myWord.GetWordString());
        myWord.HideWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine($"");
        }
    }

}