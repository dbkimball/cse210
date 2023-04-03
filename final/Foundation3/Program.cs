using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        Lectures lecture = new Lectures("Lecture", "How to care for your Equine Pet", "Come and hear a leading expert in Equine Care: Includes proper mount, hoof and wound care.", "April 17th, 2023", "3:00 PM", new Address ("42789 N. Murphy Ave", "San Tan Valley", "Arizona", "85140"), "Joe Kimball, Equine Specialist", 150);

        OutdoorGatherings outdoorGathering = new OutdoorGatherings("OutdoorGathering", "Easter Brunch & Egg Hunt", "Bring a potluck dish to share and candy filled eggs if you have children who will participate in the egghunt", "August 8th, 2023", "9:30 AM", new Address ("419 W. Yellowood Ave", "San Tan Valley", "Arizona", "85140"));

        Receptions reception = new Receptions("Reception", "Wedding Reception", "Come join us to celebrate Kaycee & Jesse on their marriage", "February 4th, 2024", "6:00 PM", new Address("42516 N. Friend Ave", "San Tan Valley", "Arizona", "85140"));

        events.Add(lecture);
        events.Add(outdoorGathering);
        events.Add(reception);

        foreach (Event e in events)
        {
            Console.WriteLine();
            Console.WriteLine(e.GetShortDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
        }

    }
}