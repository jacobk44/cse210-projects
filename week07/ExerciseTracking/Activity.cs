using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    // Constructor for a specific date
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Constructor that defaults to now
    public Activity(int minutes) : this(DateTime.Now, minutes) { }

    // Read-only properties for encapsulation
    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}
