using System;
using System.IO;

public class PromptData
{
    public static List<string> questions = new List<string> {
   "What did you learn today and how will it impact your future?",
   "What is something that you are grateful for today",
   "How did you handle a difficult situation today?",
   "What are your thoughts and feelings about your health and well-being?",
   "What is something you want to remember about this day?"};
     
    public static string PrintPrompt()
    {
        Random ranNum = new Random();
        int index = ranNum.Next(questions.Count);

        return questions[index];
    }
}