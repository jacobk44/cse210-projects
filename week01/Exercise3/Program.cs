using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magicNumber? ");
        string magicInput = Console.ReadLine();
        int magicNumber = int.Parse(magicInput);


        Console.Write("What is your guess  number? ");
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");

        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You can guessed it. ");
        }
    }
}