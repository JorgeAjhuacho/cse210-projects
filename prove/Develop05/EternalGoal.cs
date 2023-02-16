using System;

public class EternalGaol :  Goal
{
    public EternalGaol(string title, string description, int points): base(title, description,points)
    {
        _title = title;
        _description = description;
        _pointToComplete = points;
    }

    public override string GetInfo()
    {
        return $"[ ] {_title} {_description}";
    }

    public override int GetGoal(int Points)
    {
        GetInfo();
        Points += _pointToComplete;
        return Points;
    }

    public override string GetRepresentation()
    {
        return "Eternal Goal:" + _title + "," + _description + "," + _pointToComplete;
    }
}