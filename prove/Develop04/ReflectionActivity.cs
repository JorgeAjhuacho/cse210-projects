using System;

class ReflectionActivity : BaseActivity
{
    private List<string> list1 = new List<string>();
    private Random _rand = new Random();

    //----Constructors----
    public ReflectionActivity(string activityName, string activityDescription, string FinalMessage) : base (activityName, activityDescription, FinalMessage)
    {
        list1 = new List<string>();
        _rand = new Random();
    }

    //-----Getter and Setters----
    public List<string> GetListPhrase()
    {
        return list1;
    }

    public void SetPhraseList(List<string> phrase)
    {
        list1 = phrase;
    }

    public void ShowSpinnerWithText(string text, string position = "left")
    {
        string activityName = text;
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(20000);

        DateTime currentTime = DateTime.Now;

        if (position == "left")
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("| " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("/ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("— " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("\\ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("| " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("/ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("— " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("\\ " + activityName);

                Thread.Sleep(400);

                //If the user press 'Enter'
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(x + activityName.Length, y);
                    Console.Write("   ");
                    Console.WriteLine();
                    break;
                }

            }
        }
        if (position == "right")
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " |");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " /");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " —");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " \\");

                Thread.Sleep(400);
                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " |");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " /");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " —");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " \\");

                Thread.Sleep(400);

                //If the user press 'Enter'
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(x + activityName.Length, y);
                    Console.Write("   ");
                    Console.WriteLine();
                    break;
                }

            }
        }
    }

    public void AddToList(string text)
    {
        list1.Add(text);
    }

    public string GetRandom()
    {
        int index = _rand.Next(list1.Count);
        return list1[index];
    }

    public int FreezeReflectionAct(int seconds, List<string> listof, List<string> listtoquestions)
    {
        list1 = listof;
        int sec1 = seconds;
        int copy = sec1;
        DateTime newtime = DateTime.Now.AddSeconds(copy);
        int remain = seconds;
        string message = "You may begin in ";
        Console.WriteLine("Let's start...");
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        //Printing the random phrase
        Random rand = new Random();
        int index =rand.Next(0, listof.Count);
        Console.WriteLine($"{listof[index]}");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
        Console.Write("");
        string keyvalue = Console.ReadLine();

        if (keyvalue == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            
            while (DateTime.Now <= newtime){
            for (int i = 3; i > 0; i--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write($"\r{message}" + i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        // Print each question
            for (int i = 0; i < listtoquestions.Count; i++)
            {
                ShowSpinnerWithText(listtoquestions[i], "right");
                Console.WriteLine();
                if (DateTime.Now >= newtime)
                {
                    break;
                }
            }
            }
        }
        return sec1;
    }
}