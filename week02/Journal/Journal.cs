using System;
using System.Collections.Generic;
using System.IO;

// The Journal class manages a list of journal entries.
// It allows adding, displaying, saving, and loading entries.
public class Journal
{
    // List to store all journal entries
    public List<Entry> _entries = new List<Entry>();

    // Adds a new journal entry to the list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all entries in the journal, then saves them to file
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Call the Display() method on each entry
        }

        // Save entries automatically after displaying
        SaveToFile("myActivities.csv");
    }

    // Saves all entries to a file (hardcoded to "myActivities.txt")
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving To File.....");

        string filename = "myActivities.txt"; // Hardcoded filename

        using (StreamWriter writerFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Write each entry as a single line with date, prompt, and response
                writerFile.WriteLine($"{entry._date} {entry._promptText} {entry._entryText}");
            }
        }
    }

    // Loads all entries from a file and prints them to the console
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading From File");

        string filename = "myActivities.txt"; // Hardcoded filename

        // Read all lines from the file
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line); // Display each line (entry) in the file
        }
    }
}
