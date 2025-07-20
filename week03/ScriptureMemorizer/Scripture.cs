using System;

public class Scripture
{
    private Reference _reference; // Reference to the scripture location
    private List<Word> _words; // Lists of words objects for each word in the scripture. 

    // Constructors: takes reference and full exit , split text into words 
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a given number of randoms unhidden 
    public void HideRandomWords(int numberTohide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberTohide; i++)
        {
            // Get only the words that are still visible
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

            // Stop if all words are already hidden
            if (visibleWords.Count == 0) return;

            // Pick one at random and hide it 
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }

    }

    // Return the scripture reference + the full text (hiding words as needed)
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + "\n" + string.Join(" ", displayWords);

    }

    // Returns true if All words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

      public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

}