public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        SaveToFile("myActivities.csv");

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving To File.....");

        string filename = "myActivities.txt";

        using (StreamWriter writerFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writerFile.WriteLine($"{entry._date} {entry._promptText} {entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading From File");
        string filename = "myActivities.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}