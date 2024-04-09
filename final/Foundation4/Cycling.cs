// Derived class for Cycling
class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    // Override GetSpeed method
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override GetPace method
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}