using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times  in your life when you have show strength and resilence. This will help you recognize the power you have and how you can use it in other aspect of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was completed?",
            "What made this time different than other times?",
            "What is your favourite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How did you keep this experience in mind?"
        };
    }
    public override void Run()
    {

        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuetions()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(1000);

    }

   public void DisplayQuestions()
{
    int elapsed = 0;
    List<string> shownQuestions = new List<string>();

    while (elapsed < _duration)
    {
        string question;

        // Keep getting a new random question until it's not already shown
        do
        {
            question = GetRandomQuetions();
        } while (shownQuestions.Contains(question) && shownQuestions.Count < _questions.Count);

        shownQuestions.Add(question);
        Console.WriteLine(">" + question);
        ShowSpinner(4);
        elapsed += 4;
    }
}

}