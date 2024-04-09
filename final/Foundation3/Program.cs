using System;
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Othertown", "NY", "USA");
        Address address3 = new Address("789 Elm St", "Another town", "FL", "USA");

        // Create events
        Lecture lecture = new Lecture("Lecture Title", "Description of the lecture", DateTime.Now.Date, new TimeSpan(10, 0, 0), address1, "John Doe", 100);
        Reception reception = new Reception("Reception Title", "Description of the reception", DateTime.Now.Date, new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Gathering Title", "Description of the outdoor gathering", DateTime.Now.Date, new TimeSpan(15, 0, 0), address3, "Sunny");

        // Display marketing messages for each event
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(gathering.GetFullDetails());
    }
}