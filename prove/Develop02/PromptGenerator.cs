using System;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{

    public List<string> _prompts = new List<string>{
        "What was the most surprising thing I learned today?",
        "Did I take any time for self-care or relaxation today? If so, how did it benefit me?",
        "What was the most delicious thing I ate today, and what made it special?",
        "How did I contribute positively to someone else's day today?",
        "Did I experience any moments of pure joy or laughter today? If so, what caused them?",
        "What new skill or knowledge did I acquire today, no matter how small?",
        "Did I encounter any setbacks or challenges today? How did I overcome or cope with them?",
        "How did I demonstrate resilience or perseverance today?",
        "Did I make progress towards resolving any ongoing issues or conflicts today?",
        "What part of nature did I appreciate or connect with today",
        "Did I take time to express gratitude or appreciation to someone important in my life today?",
        "What inspired me today, whether it was a person, a story, or an idea?",
        "How did I prioritize my mental and emotional well-being today?",
        "Did I engage in any acts of creativity or self-expression today?",
        "What can I do differently tomorrow to make it an even better day?"
    };

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}