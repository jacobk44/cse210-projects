using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;  // Treat as a single verse


    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // Constructor for a range of verses
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {

        // Return the reference in string format: e.g "Proverbs 3:5-6"
        return _verse == _endVerse
            ? $"{_book} {_chapter}:{_verse}"
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    
    public static Reference Parse(string input)
    {
        string[] parts = input.Split(' ');
        string book = parts[0];
        string[] verses = parts[1].Split(':');
        int chapter = int.Parse(verses[0]);

        if (verses[1].Contains("-"))
        {
            var range = verses[1].Split('-');
            int verseStart = int.Parse(range[0]);
            int verseEnd = int.Parse(range[1]);
            return new Reference(book, chapter, verseStart, verseEnd);
        }
        else
        {
            int verse = int.Parse(verses[1]);
            return new Reference(book, chapter, verse);
        }
    }
}