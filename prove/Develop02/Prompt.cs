using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompt = new List<string>
    {
        "What was the best part of my day?",
        "What did I learn today",
        "Who did I bless today?",
        "How did I see the Lord's hand in my life today?",
        "What can I do better tomorrow?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompt.Count);

        return _prompt[index];
    }
}