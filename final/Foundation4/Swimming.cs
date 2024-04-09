// Derived class for Swimming
class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    // Override GetDistance method
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Convert meters to miles
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60.0);
    }

    // Override GetPace method
    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}