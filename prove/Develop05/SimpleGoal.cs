// Derived class for simple goals
class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Override RecordEvent method
    public override void RecordEvent()
    {
        _isComplete = true;
        base.RecordEvent();
    }

    // Override IsComplete method
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override GetStringRepresentation method
    public override string GetStringRepresentation()
    {
        return _isComplete ? $"{_shortName} [X]" : $"{_shortName} [ ]";
    }
}