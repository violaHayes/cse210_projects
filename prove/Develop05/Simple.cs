public class Simple: Goal
{
    private bool _isComplete;
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
     public Simple(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _numberOfPoints;
        }
        return 0;
        
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailString()
    {
        string completionMarker = IsComplete()? "[X]" : "[ ]";
        return $"{completionMarker} {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}, {_isComplete}";
    }
}   