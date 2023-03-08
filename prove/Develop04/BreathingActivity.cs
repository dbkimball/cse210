using System;

public class BreathingActivity : Activity
{


    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _activityName = "Breathing Activity";


    private void BreathIn()
    {
        Console.Write("Breath in... ");
        CountDown(3);
        Console.WriteLine();
    }

    private void BreathOut()
    {
        Console.Write("Now breath out... ");
        CountDown(3);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void BreathingCycles(int timer)
    {
        GetReady(3);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timer);
        while (VerifyTime(timer, futureTime))
        {
            BreathIn();
            BreathOut();
        }
    }

    //getters and setters

    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
}