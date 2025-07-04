using System;

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



// Stretch Requirement 

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Random randomGenerateNumber = new Random();
//         int magicNumber = randomGenerateNumber.Next(1, 100);

//         int guessNumber = -1;

//         while (guessNumber != magicNumber)
//         {
//             Console.Write("What is your guessNumber? ");
//             guessNumber = int.Parse(Console.ReadLine());

//             if (magicNumber > guessNumber)
//             {
//                 Console.WriteLine("Higher");
//             }
//             else if (magicNumber < guessNumber)
//             {
//                 Console.WriteLine("Lower");
//             }
//             else
//             {
//                 Console.WriteLine("You can guessed it. ");
//             }

//         }
//     }
// }