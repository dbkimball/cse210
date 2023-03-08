using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        Activity activity = new Activity();



        bool startProgram = true;
        while (startProgram)
        {

            activity.Menu();

            int answer = Convert.ToInt32(Console.ReadLine());

            int timer;

            if (answer == 1)
            {
                breathingActivity.GetIntro(breathingActivity.GetActivityName(), breathingActivity.GetDescription());
                timer = breathingActivity.Time();
                breathingActivity.BreathingCycles(timer);
                breathingActivity.GetOutro(timer, breathingActivity.GetActivityName());

            }

            else if (answer == 2)
            {
                reflectingActivity.GetIntro(reflectingActivity.GetActivityName(), reflectingActivity.GetDescription());
                timer = reflectingActivity.Time();
                reflectingActivity.Reflect(timer);
                reflectingActivity.GetOutro(timer, reflectingActivity.GetActivityName());

            }
            else if (answer == 3)
            {
                listingActivity.GetIntro(listingActivity.GetActivityName(), listingActivity.GetDescription());
                timer = listingActivity.Time();
                listingActivity.AddList(timer);
                listingActivity.GetOutro(timer, listingActivity.GetActivityName());

            }
            else if (answer == 4)
            {
                break;
            }
        }
    }
}