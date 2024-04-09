// Derived class for eternal goals
class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
    }

    // Override RecordEvent method
    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}
