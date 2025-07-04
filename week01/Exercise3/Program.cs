using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerateNumber = new Random();
        int magicNumber = randomGenerateNumber.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("what is your guess number? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it.");
            }
        }
    }
}