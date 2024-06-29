using System;

public class PromptGenerator
{
    private static readonly string[] _prompts = new string[]
    {
        "What did you learn today?",
        "What are you grateful for?",
        "What's been on your mind lately?",
        "What's something you're looking forward to?",
        "What's a goal you want to achieve this week?",
        "What's something you're proud of?",
        "What's a challenge you're facing?",
        "What's something you want to improve about yourself?",
        "What's a book or article you've read recently?",
        "What's a skill you want to learn?"
    };

    private static Random _random = new Random();

    public string GeneratePrompt()
    {
        int index = _random.Next(0, _prompts.Length);
        return _prompts[index];
    }
}