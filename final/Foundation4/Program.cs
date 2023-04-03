using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("April 4th, 2023",  30, "Running", 2);
        Cycling cycling = new Cycling("April 6th, 2023", 60, "Cycling", 10);
        Swimming swimming = new Swimming("April 8th, 2023", 45, "Swimming", 20);
        
        activities.Add(run);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        Console.WriteLine("Your activities for this week are:\n");


        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
           
        }

    }
}