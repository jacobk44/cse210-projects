// Represent a single journal entry with a date, a prompt and user's response.
public class Entry
{
    // The date the entry jouranl was created
    public string _date;
    
    // The propmt question that was asked.
    public string _promptText;

    // The user's response to the prompt.
    public string _entryText;

    // Display the entry's date, prompt, and response in a single line.
    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }
}