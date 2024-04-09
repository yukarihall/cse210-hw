// Derived class for Outdoor Gatherings
class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // Override GetFullDetails method
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
