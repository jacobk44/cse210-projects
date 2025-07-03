using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = gradePercent % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && gradePercent < 93)
        {
            sign = "-";  // Only A and A- allowed
        }

        // Print final grade
        Console.WriteLine($"Your grade letter is {letter}{sign}");

        // Extra message
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You have qualified for the exam.");
        }
        else
        {
            Console.WriteLine("Stay focused — you can do better, keep trying!");
        }
    }
}
