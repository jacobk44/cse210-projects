using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(new DateTime(2025, 8, 14), 30, 5.0);
        Cycling cycling = new Cycling(new DateTime(2025, 8, 14), 45, 20.0);
        Swimming swimming = new Swimming(new DateTime(2025, 8, 14), 25, 50);


        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);


        // Console.WriteLine(running.GetSummary());
        // Console.WriteLine(cycling.GetSummary());
        // Console.WriteLine(swimming.GetSummary());

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

        }


    }
}