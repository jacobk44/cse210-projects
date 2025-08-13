using System;
using System.Collections.Generic;

public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    { }
    public override bool isComplete()
    {
        return false;
    }
    
        public override string GetDetailsString()
    {
        string status = isComplete() ? "[x]" : "[]";
        return $"{status} {_name} ({_description})";
    }
    public override string GetStringPresentation()
    {
        return $"Eternal Goal: {_name} ({_description}) {_points}";

    }
}