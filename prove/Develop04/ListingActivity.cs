using System;

public class ListingActivity : BaseActivity
{
    private List<string> _list1 = new List<string>();
    private Random _rand = new Random(); 

    //------Constructors------
    public ListingActivity(string actName, string actDescription,string FinalMessage) : base (actName, actDescription, FinalMessage)
    {
        _list1 = new List<string>();
        _rand = new Random(); 
    }

    //-----Getter and Setters--------
    public List<string> GetListPrompt()
    {
        return _list1;
    }

    public void SetList (List<string> list)
    {
        _list1 = list;
    }  

    //----Methods-----
    public void AddtoList(string phrase)
    {
        _list1.Add(phrase);
    }

    public string GetRndOne()
    {
        int rnd = _rand.Next(_list1.Count);
        return _list1[rnd];
    }

    private void ShowSpinnerWithText(string text, string position = "left")
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
    public int FreezeListingAct(int seconds, List<string> listready)
    {
        _list1 = listready;
        int sec1 = seconds;
        int copy = sec1;
        int count = 0;
        DateTime newtime = DateTime.Now.AddSeconds(copy);

        int remain = seconds;
        string message = "You may begin in: ";
        Console.WriteLine("Let start...");
        ShowSpinnerWithText("");
        Console.Clear();
        Console.WriteLine("list as many responses you can do to the following prompt: ");
        Console.WriteLine();

        Random rand = new Random();
        int i = rand.Next(0, listready.Count);
        Console.WriteLine($"----{listready[i]}----");
        Console.WriteLine();

        List<string> listfinal = new List<string>();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        for (int k = 3;k >0; i--)
        {
            Console.SetCursorPosition(x,y);
            Console.Write($"{message}  {k}");
            Thread.Sleep(1000);
        }

        while (DateTime.Now <= newtime)
        {
            Console.Write("");
            string input = Console.ReadLine();
            listfinal.Add(input);
            count += 1;

            if (DateTime.Now >= newtime)
            {
                break;
            }

            foreach (var value in listfinal)
            {
                Console.WriteLine(value);
            }
        }
        
            Console.WriteLine("");
            Console.WriteLine($"You listed {count} items. ");
        return sec1;
    }
}