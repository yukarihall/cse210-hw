// Derived class for checklist goals
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) 
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override RecordEvent method
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus; // Add bonus points when goal is completed
        }
        base.RecordEvent();
    }

    // Override IsComplete method
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override GetDetailsString method
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} (Completed {_amountCompleted}/{_target} times)";
    }
}