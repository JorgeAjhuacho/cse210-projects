using System;

public class SimpleGoal: Goal
{
    private bool _checked = false;
    private bool _completed = false;

    public SimpleGoal(string title, string description, int points, bool checkeds = false) : base(title, description, points)
    {
        _title = title;
        _description = description;
        _pointToComplete = points;
        _checked = checkeds;
    }

    public override string GetInfo()
    {
        if (_checked){
            _completed = true;
            return "[X] "+_title + " ("+ _description + ")";
        }
        else{
            return "[ ] "+_title + " ("+ _description + ")";
        }
    }

    public override int GetGoal(int Points)
    {
        bool completed = _completed;
        _checked = true;

        if (completed == false){
            GetInfo();
            Points += _pointToComplete;
            completed = true;
            return Points;
        }
        else{
            GetInfo();
            return Points;
        }
    }

    public override string GetRepresentation()
    {
        return "Simple Goal:" + _title + "," + _description + "," + _pointToComplete + "," + _checked;
    }
}