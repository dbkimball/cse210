using System;
using System.Threading;

public class Activity
{

    protected string _welcomeMessage = "Welcome to the ";

    protected List<string> _spinner = new List<string>();

    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();


    public void GetIntro(string activityName, string description)
    {

        Console.Clear();
        Console.WriteLine(_welcomeMessage + activityName);
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

    }

    public void Menu()
    {
        Console.Clear();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");

    }
    // public void AnimationText (int seconds)
    // {
    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(seconds);
    //     int i = 0;
    //     while (DateTime.Now < endTime)
    //     {
    //         string s = _spinner[i];
    //         Console.Write(s);
    //         Thread.Sleep(500);
    //         Console.Write("\b \b");
    //         i++;
           
    //         if (i >= _spinner.Count)
    //         {
    //             i = 0;
    //         }
            
    //     }
    // }
    public void Spinner(int seconds)
    {

        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");

        //Console.CursorVisible = false;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            //Console.Clear();
            Console.Write("\b \b");
            i++;
            //Console.CursorVisible = true;

            if (i >= _spinner.Count)
            {
                i = 0;
            }
            
        }
    }
    public void GetReady(int seconds)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(seconds);
        Console.WriteLine();
    }


    public int Time()
    {
        Console.Write("How long, in seconds, would you like for your session: ");
        int howLongTime = Convert.ToInt32(Console.ReadLine());
        return howLongTime;
    }


    public bool VerifyTime(int timer, DateTime futuretime)
    {

        if (DateTime.Now < futuretime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected string SelectRandomItem(List<string> list)
    {

        Random randomGenerator = new Random();

        int randomprompt = randomGenerator.Next(0, list.Count);
        string prompt = list[randomprompt];
        return prompt;
    }


    public void CountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetOutro(int seconds, string activity)
    {
        Console.WriteLine();
        Console.WriteLine("well Done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {seconds} seconds of the {activity}");
        Spinner(7);

    }



}