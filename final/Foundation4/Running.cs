// Derived class for Running
class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    // Override GetDistance method
    public override double GetDistance()
    {
        return _distance;
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return _distance / (_lengthInMinutes / 60.0);
    }

    // Override GetPace method
    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }
}