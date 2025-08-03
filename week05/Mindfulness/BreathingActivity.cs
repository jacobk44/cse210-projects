using System;
using System.Collections.Generic;

public class BreathingActivity: Activity
{ 
    public BreathingActivity() : base("BreathingActivity", "This activity will help you relax by walking you through 'Breathing in...' and out slowly. Clear your mind and focus on your breathing.")
    {}
    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in.....");
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            Console.Write("Breathe out.....");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine();
            Console.WriteLine();

           
        }

        DisplayEndingMessage();


    }
}