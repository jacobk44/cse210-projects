
// EXCEEDS REQUIREMENTS:
// 1. Introduced a Scripture Library that holds multiple scriptures.
// 2. Randomly selects one scripture from the library for each session,
//    making the program more dynamic and useful for long-term study.
// 
// These features make the program more versatile and helpful for users 
// who want variety and challenge when memorizing scriptures.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture library
        ScriptureLibrary library = new ScriptureLibrary();

        // Add multiple scriptures
        library.AddScripture(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy path."));

        library.AddScripture(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));

        library.AddScripture(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ who strengthens me."));

        // Get a random scripture from the library
        Scripture scripture = library.GetRandomScripture();

        // Loop until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit") return;

            scripture.HideRandomWords(3);
        }

        // Final message when all words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
