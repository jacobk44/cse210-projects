using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;

    }

    public override void RecordEvent()
    {
        _isComplete = true;

    }

    public override bool isComplete()
    {
        return _isComplete;

    }

    public override string GetDetailsString()
    {
        string status = isComplete() ? "[x]" : "[]";
        return $"{status} {_name} ({_description})";
    }


    public override string GetStringPresentation()
    {
        return $"Simple Goal:{_name} ({_description}) {_points} {_isComplete}";
    }

}