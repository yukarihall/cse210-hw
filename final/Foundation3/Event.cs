// Base class for all types of events
class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to get standard details
    public string GetStandardDetails()
    {
        return $"Event Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    // Method to get full details (virtual method to be overridden by derived classes)
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Method to get short description
    public string GetShortDescription()
    {
        return $"Type of Event: {GetType().Name}\nEvent Title: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}