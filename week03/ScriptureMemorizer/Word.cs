using System;

public class Word
{
    private string _text; // The word itself
    private bool _isHidden; // Whether the word is currently hidden

    // Constructor set the word and default it to visible.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide() => _isHidden = true;

    // Show the word
    public void Show() => _isHidden = false;

    // Check if the word is hidden
    public bool IsHidden() => _isHidden;

    //Return the word if visisble, or underscore if hidden
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
    
}
