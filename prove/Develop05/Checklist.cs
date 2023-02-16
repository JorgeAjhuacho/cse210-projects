using System;

public class Checklist : Goal
{
    private int _actualCount;
    private int _verificationCount;
    private int _bonusCompleted;
    private bool _checked = false;

    public Checklist(string title, string description, int points) : base(title, description, points)
    {
        _title = title;
        _description = description;
        _pointToComplete = points;
    }

    public Checklist(string title, string description, int points, int actualcount, int verificationcount = 0) : base(title, description, points)
    {
        _title = title;
        _description = description;
        _pointToComplete = points;
        _verificationCount = verificationcount;
        _actualCount = actualcount;
    }

    public Checklist(string title, string description, int points, int verificationCount, int bonusCompleted, int actualCount = 0, bool checkeds = false)
    {
        _title = title;
        _description = description;
        _pointToComplete = points;
        _verificationCount = verificationCount;
        _bonusCompleted = bonusCompleted;
        _actualCount = actualCount;
        _checked = checkeds;
    }

    //-----Getters and Setters ------
    public int GetVerificationCount()
    {
        return _verificationCount;
    }
    public void SetVerificationCount(int verCountToSet)
    {
        _verificationCount = verCountToSet;
    }

    public int GetBonusCompleted()
    {
        return _bonusCompleted;
    }
    public void SetBonusCompleted(int bonusCompleted)
    {
        _bonusCompleted = bonusCompleted;
    }

    public int GetActualCount()
    {
        return _actualCount;
    }
    public void SetActualCount(int actualCount)
    {
        _actualCount = actualCount;
    }

    public override string GetInfo()
    {
        if(_checked)
        {
            return $"[X] {_title} ({_description}) -- Currently completed {GetActualCount()}/{_verificationCount}";
        }
        else{
            return $"[ ] {_title} ({_description}) -- Currently completed {GetActualCount()}/{_verificationCount}";
        }
    }

    public override int GetGoal(int Points)
    {
        _actualCount += 1;
        int actualCount = _actualCount;
        SetActualCount(actualCount);

        string goalInfo = GetInfo();
        int index = _listOfGoals.IndexOf(goalInfo);
        string newGoalInfo;

        if (_actualCount == _verificationCount)
        {
             _checked = true;
             newGoalInfo = GetInfo();
             Points += _bonusCompleted;
             Points += _pointToComplete;
        }
        else if (_actualCount > _verificationCount)
        {
            _actualCount -= 1;
        }
        else{
            newGoalInfo = goalInfo;
            Points += _pointToComplete;
        }
        return Points;

    }

    public override string GetRepresentation()
    {
        return "CheckListGoal:" + _title + "," + _description + ";" + _pointToComplete + "," + _verificationCount + "," + _bonusCompleted + "," + _actualCount;
    }
}
