using System;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string eventType, string title, string description, string date, string time, Address address) : base(eventType, title, description, date, time, address)
    {
        
        _weather = "In Case of inclement weather the event will be moved to the LDS Church Building on the corner of Ocotillo & Ironwood";
    }

    public string GetOutdoorFullDetails()
    {
        string fullDetails = GetFullDetails();
        return $"{_weather}";
    }
}