using System;

public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _pointToComplete;

    protected List<string> _listOfGoals = new List<string>();

    //------Constructors----
    public Goal()
    {
        _title = "";
        _description = "";
        _pointToComplete = 0;
    }
    public Goal(string title)
    {
        _title = title;
        _description = "";
        _pointToComplete = 0;
    }
    public Goal(string title, string description)
    {
        _title = title;
        _description = description;
        _pointToComplete = 0;
    }
    public Goal(string title, string description, int pointtocomplete)
    {
        _title = title;
        _description = description;
        _pointToComplete = pointtocomplete;
    }

    //Getter and Setters----
    public string GetName()
    {
        return _title;
    }
    public void SetName(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPointsToComplete()
    {
        return _pointToComplete;
    }
    public void SetPointsToComplete(int pointsToComplete)
    {
        _pointToComplete = pointsToComplete;
    } 

    //-----Methods------
    public virtual string GetInfo()
    {
        return $"[] {_title} ({_description})";
    }

    public virtual int GetGoal(int Points)
    {
        return Points;
    }

    public virtual string GetRepresentation()
    {
        return "Goal:" + _title + "," + _description + "," + _pointToComplete + "," + false;
    }
}