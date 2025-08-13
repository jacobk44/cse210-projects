using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        string status = isComplete() ? "[x]" : "[]";
        return $"{status} {_name} ({_description}) -- Currently Completed {_amountCompleted}/{_target} ";
    }

    public override string GetStringPresentation()
    {
        return $"ChecklistGoal: {_name} ({_description}) {_points} {_bonus} {_amountCompleted}/{_target}";
    }

}