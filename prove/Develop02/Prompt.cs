class Prompt
{
    public string[] _promptStrings =
    {
        "What was a highlight of your day",
        "What was something that didn't go well today",
        "What was something that someone did that made you smile today",
        "What was a goal you accomplished today",
        "What was the biggest emotion you felt today",
    };


    public string GetPrompt()
    {
        Random rand= new Random();
        return _promptStrings[rand.Next(0, _promptStrings.Length)];
    }
}