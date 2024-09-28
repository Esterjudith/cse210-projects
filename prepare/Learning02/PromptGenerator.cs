using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What made me happy today?",
        "What did I learn today?",
        "Who did I help today?",
        "What am I grateful for today?"
    };

    public string GetRadomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}