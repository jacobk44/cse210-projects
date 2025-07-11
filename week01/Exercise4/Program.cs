using System;
using System.Globalization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit)");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }



        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");


        // Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");


        // compute the max 
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;

            }
        }
        Console.WriteLine($"The largest number is {max}");
    }
}                            