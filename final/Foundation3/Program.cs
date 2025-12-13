using System;

class Program
{
    static void Main(string[] args)
    {

        
        Address address1 = new Address("100 College Ave", "Rexburg", "ID", "USA");
        Address address2 = new Address("50 Event Rd", "Boise", "ID", "USA");
        Address address3 = new Address("1 Park Way", "Salt Lake City", "UT", "USA");

        Event lecture = new Lecture(
            "Tech Talk",
            "Latest trends in software",
            "April 15, 2025",
            "6:00 PM",
            address1,
            "Dr. Smith",
            200
        );

        Event reception = new Reception(
            "Networking Night",
            "Meet industry professionals",
            "May 10, 2025",
            "7:00 PM",
            address2,
            "rsvp@events.com"
        );

        Event outdoor = new OutdoorGathering(
            "Summer Festival",
            "Food, music, and games",
            "June 20, 2025",
            "3:00 PM",
            address3,
            "Sunny, 75 F"
        );

        DisplayEvent(lecture);
        DisplayEvent(reception);
        DisplayEvent(outdoor);
    }

    static void DisplayEvent(Event ev)
    {
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(ev.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(ev.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(ev.GetShortDescription());
    }
}
