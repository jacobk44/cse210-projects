using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jacob", "What can i do you please?");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment("Jacob Amoah", "Fractions", "7.9", "8-9");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The cuase of the World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine();

    }
}