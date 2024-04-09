// Base class for all activities
class Activity
{
    private DateTime _date;
    public int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Virtual method to get the distance
    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance
    }

    // Virtual method to get the speed
    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed
    }

    // Virtual method to get the pace
    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace
    }

    // Method to get summary
    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_date.ToShortTimeString()} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}