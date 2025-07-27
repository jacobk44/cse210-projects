using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public int GetLengthInSeconds()
    {
        return _comments.Count;
    }

    public void DidplayInfo()
    {
        Console.WriteLine($"Video {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}");
        Console.WriteLine($"Comments: {GetLengthInSeconds()}");

        foreach(Comment comment in _comments){
        comment.Display();
    }
    }
    
}