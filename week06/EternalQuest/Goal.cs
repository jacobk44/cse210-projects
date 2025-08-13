using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    
    public int GetPoint()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetailsString(){
        string status = isComplete() ? "[x]" : "[]";
        return $"{status} {_name} {_description}";
    }

    public abstract string GetStringPresentation();
}