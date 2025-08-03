using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}\n{_description}");
        Console.Write("Enter your duration...");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin");
        ShowSpinner(4);

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done.");
        ShowSpinner(2);
        Console.WriteLine($"You completed {_name} for {_duration} seconds ");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
    public abstract void Run();

}