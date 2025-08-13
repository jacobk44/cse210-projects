using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();

    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points ");
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. List GoalsNames");
            Console.WriteLine(" 4. Save Goals");
            Console.WriteLine(" 5. Load Goals");
            Console.WriteLine(" 6. Record Event");
            Console.WriteLine(" 7. Quit");
            Console.Write(" Select a choice ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    ListGoalNames();
                    break;
                case "4":
                    SaveGoal();
                    break;
                case "5":
                    LoadGoal();
                    break;
                case "6":
                    RecordEvent();
                    break;
                case "7":
                    running = false;
                    break;
            }
        }

    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have scored {_score} points");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals name");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetName()}");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The type of Goals are..");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new Eternal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplish for a bonus ?");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus of accomplishing it that may times");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine($"DEBUG: Goals in memory = {_goals.Count}");

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoint();
            Console.WriteLine($"Event recorded! You now have {_score} points. ");
        }
        else
        {
            Console.WriteLine("Invalid goal selection");
        }
        Console.WriteLine("Press Enter to continue....");
        Console.ReadLine();
    }



    private void SaveGoal()
    {
        Console.Write("Enetr the filename to save...");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringPresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Console.ReadLine();
    }

    
    private void LoadGoal()
    {
        Console.Write("Enter your filename: ");
        string filename = Console.ReadLine();

        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // if (string.IsNullOrWhiteSpace(line)) continue; // Skip empty lines

            string[] parts = line.Split(',');

            // Skip lines that don't have enough data
            if (parts.Length < 4)
            {
                Console.WriteLine($"{line}");
                continue;
            }

            string type = parts[0].Trim();
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                if (parts.Length < 5) continue; // Ensure index exists
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name, description, points);
                if (isComplete) sg.RecordEvent(); // Use proper completion method
                _goals.Add(sg);
            }
            else if (type == "Eternal")
            {
                _goals.Add(new Eternal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                if (parts.Length < 7) continue;
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                cg.SetAmountCompleted(amountCompleted);
                _goals.Add(cg);
            }
        }

        Console.WriteLine($"Loaded {_goals.Count} goals from {filename}");
    }

} 