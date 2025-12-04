public class Eternal: Goal
{
    public Eternal(string name, string description, int points, bool status) : base(name, description)
    {
        
    }
    public Eternal(string name, string description, int points, int timesRecorded, bool status) : base(name, description)
    {
        
    }
    public override int RecordEvent()
    {
        return _numberOfPoints; 
    }
    public override string GetConsoleString()
    {
        return $"Eternal Goal: {_name}, {_description}, {_numberOfPoints}";
    }

    
}