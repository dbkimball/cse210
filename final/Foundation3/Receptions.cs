using System;

public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string eventType, string title, string description, string date, string time, Address address) : base(eventType, title, description, date, time, address)
    {
        _rsvp = $"Please RSVP to receptionemail@gmail.com 2 weeks before {GetDate()}.";
    }

    public string GetReceptionDetails()
    {
        string fullDetails = GetFullDetails();
        return $"{_rsvp}";
    }
}