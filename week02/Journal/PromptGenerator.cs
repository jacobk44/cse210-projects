public class PromptGenerator
{
    public List<string> _propmt = new List<string>
    {
        "Who was the most interesting person i interacted with today? ",
        "What is the best part of my day? ",
        "How did i see the hand of the Lord in my life today? ",
        "What was the strongest emotion i felt today? ",
        "If i had one thing i could do over today, what would it be? "
    };

    Random _random = new Random();


    public string GetRandomPrompt()
    {
        return _propmt[_random.Next(_propmt.Count)];
    }
}