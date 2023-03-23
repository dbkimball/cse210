using System;

public class Goal
{

    public string _goalName;
    public string _goalDescription;
    public int _goalPoints;

    public int _accumulatedPoints = 0;
    public string _goalType;

    public int _numTimesToComplete;
    public int _pointsPerTime;

    public int _timesCompleted = 0;

    public string _isCompleted = "false";

    public virtual void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal: ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());
    }

    public virtual string GetStringRepresentation()
    {
        return ($"{_goalType}: {_goalName}, {_goalDescription}, {_goalPoints}");
    }

    public void SetGoalDescription(string description)
    {
        _goalDescription = description;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public void SetisCompleted(string isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public void SetPointsPerTime(int pointsPerTime)
    {
        _pointsPerTime = pointsPerTime;
    }

    public void SetTimesToComplete(int SetTimesToComplete)
    {
        _numTimesToComplete = SetTimesToComplete;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

}