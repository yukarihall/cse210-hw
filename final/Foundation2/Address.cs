class Address
{
    public string StreetAddress { get; }
    public string City { get; }
    public string StateOrProvince { get; }
    public string Country { get; }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}, {City}, {StateOrProvince}, {Country}";
    }
}