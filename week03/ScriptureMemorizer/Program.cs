using System;

class Program
{
    static void Main(string[] args)
    {   // Create a reference for the scripture (Proverbs 3:5-6)
        Reference reference = new Reference("Provebrs", 3, 5, 6);
        
        // Full scripture text
        string text = "Trust in the Lord with all your heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy path. ";

        // Create a scripture object from the reference and text
        Scripture scripture = new Scripture(reference, text);

        // Loop untill all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console screen
            Console.Clear();

            // Display the current state for the scripture. 
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user to press "Enter" or type "Quit"
            Console.WriteLine("\nPress Enter to hide more words or type  'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            // If the user type "Quit" end the program.
            if (input == "quit") return;

            // Hide a few (3) random words
            scripture.HideRandomWords(3);

            // Finally display when all are hidden
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program ended");
        }
    }
}