using System;
using System.IO;

public class BaseActivity
{
    private string _activityName;
    private int _activityDuration;
    private string _activityDescription;
    private string _finalMessage;

    public BaseActivity()
    {
        //Constructot for default values
        _activityName = "Unknown";
        _activityDescription = "Unknown";
        _finalMessage = "Unknown";
    }
     public BaseActivity(string ActName)
     {
        _activityName = ActName;
        _activityDescription = "Unknown";
        _finalMessage = "Unknown";
     }
     public BaseActivity(string ActName, string ActivityDescription)
     {
        _activityName = ActName;
        _activityDescription = ActivityDescription;
     }
    
    public BaseActivity(string ActName, string ActivityDescription, string FinalMessage)
    {
        _activityName = ActName;
        _activityDescription = ActivityDescription;
        _finalMessage = FinalMessage;
    }

    //------Getter and Setters------
    public string GetActName()
    {
        return _activityName;
    }

    public void SetActName(string ActName)
    {
        _activityName = ActName;
    }

    public int GetActDuration()
    {
        return _activityDuration;
    }

    public void SetActDuration(int actDuration)
    {
        _activityDuration = actDuration;
    }

    public string GetActDescription()
    {
        return _activityDescription;
    }

    public void SetActDescription(string ActivityDescription)
    {
        _activityDescription = ActivityDescription;
    }
    public string GetFinalMessage()
    {
        return _finalMessage;
    }

    public void SetFinalMessage(string FinalMessage)
    {
        _finalMessage = FinalMessage;
    }

    public string PrintActivityName()
    {
        return $"Welcome to the {_activityName}.";
    }

    public string PrintActivtyDescription()
    {
        return $"{_activityDescription}";
    }

    public string PrintActivityDuration()
    {
        Console.Write("How long in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        return time;
    }

    public string PrintFinalMessage()
    {
        Console.WriteLine("Well Done.");
        Console.WriteLine();
        Convert.ToString(_activityDuration);
        return $"You have completed {_activityDuration} seconds of the {_activityName}.";
    }
}