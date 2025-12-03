public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _numberOfPoints;
    protected bool _status;
    protected string _goalType;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();


    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }
    public string GetName()
    {
        return _name;
    }


public virtual string GetConsoleString()
    {
    return $"Name: {_name}, Description: {_description}, Points: {_numberOfPoints}, Status: {_status}";
}
}