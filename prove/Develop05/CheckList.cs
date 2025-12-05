public class ChecklistGoal : Goal
{
    private int _timesCompleted; 

    private int _bonusPoints;    
    private int _targetAmount;   

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _targetAmount = target;
        _bonusPoints = bonus;
        _timesCompleted = 0; 


    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed) 
        : base(name, description, points)
    {
        _targetAmount = target;
        _bonusPoints = bonus;

        _timesCompleted = completed; 
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _timesCompleted++;
            int totalPoints = _points;

            if (IsComplete())
            {
                totalPoints += _bonusPoints;
                    Console.WriteLine($"*** Goal Completed! You earned a bonus of {_bonusPoints} points! ***");
            }
            return totalPoints;
        }
        return 0;
    }
    
    public override bool IsComplete()
    {
        return _timesCompleted >= _targetAmount;
    }

    public override string GetDetailString()
    {
        string completionMarker = IsComplete() ? "[X]" : "[ ]";
        string progress = $" -- Currently completed {_timesCompleted}/{_targetAmount} times";

        return $"{completionMarker} {_shortName} ({_description}){progress}";
    }

    public override string GetStringRepresentation()
    {
        
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_targetAmount},{_bonusPoints},{_timesCompleted}";
    }
}