// Base class for all types of goals
class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Method to record an event (e.g., completing the goal)
    public virtual void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {_shortName}.");
    }

    // Method to check if the goal is complete
    public virtual bool IsComplete()
    {
        return false; // Base class Goal is not complete
    }

    // Method to get details of the goal
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    // Method to get a string representation of the goal
    public virtual string GetStringRepresentation()
    {
        return _shortName;
    }
}