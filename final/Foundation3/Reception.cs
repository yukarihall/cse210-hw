// Derived class for Receptions
class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Override GetFullDetails method
    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}