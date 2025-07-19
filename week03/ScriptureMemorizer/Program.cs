using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Provebrs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy path. ";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type  'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit") return;

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program ended");
        }
    }
}