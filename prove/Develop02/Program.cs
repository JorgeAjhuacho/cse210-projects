using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Questions added to a list
        List<string> prompts = new List<string>();
        prompts.Add("What did you learn today and how will it impact your future?");
        prompts.Add("What is something that you are grateful for today");
        prompts.Add("How did you handle a difficult situation today?");
        prompts.Add("What are your thoughts and feelings about your health and well-being?");
        prompts.Add("What is something you want to remember about this day?");

        for(int i=0; i < prompts.Count();i++)
        {
            Console.WriteLine(prompts[i]);
        }
    }
}