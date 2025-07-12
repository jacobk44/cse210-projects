using System;

// The main class where the application start.
class Program
{
    //  This is the entry point of the program. it runs when you start the application.
    static void Main(string[] args)
    {
        // Create a new instance of the Journal class to store the journal entries. 
        Journal journal = new Journal();

        // Create a new instance of the PrompGenerator that supllies random quetions
        //  to hgelp the user write the journal entries. 
        PromptGenerator promptGenerator = new PromptGenerator();

        //  Initialize a string to store the user's menu choice.
        string choice = "";

        // Runs the menu repeatedly untill the user select 5(Quit).
        while (choice != "5")

        {
            // Display the menu options to the user. 
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            // Reads the user input(1-5).
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":// Write a new entry. 

                    // Get a random prompt
                    // Ask the user to respond
                    // Saves the response, prompt and today's date in a new entry object
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    // Create and add the entry to the journal 
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = prompt,
                        _entryText = response
                    };
                    journal.AddEntry(newEntry);
                    break;

                case "2":// Display all entries currently in the journal.
                    journal.DisplayAll();
                    break;

                case "3": // Ask a file name and save the entries. 
                    Console.Write("Enter filename to save (e.g. journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4": // Ask the file name and load entries from it.
                    Console.Write("Enter filename to load (e.g. journal.txt): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5": // Ends the program loop and prints a farewall message
                    Console.WriteLine("Goodbye!");
                    break;

                default:// If the user types something else. show an error message.
                    Console.WriteLine("Invalid option. Please enter 1-5.");
                    break;
            }
        }
    }
}