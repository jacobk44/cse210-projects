using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good thing in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
     {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this morning?",
        "Who are some of your personal heroes?"
     };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();

        return _prompts[rand.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Start listing items (Press Enter after each):");

        while (DateTime.Now < end)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    userList.Add(input);
            }
        }
        return userList;
    }

    
    
}