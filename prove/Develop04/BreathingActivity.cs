using System;
using System.IO;
//Calling for the Base Class
public class BreathingActivity : BaseActivity
{
    private DateTime _freezeTime;
    //-----Constructors-------
    public BreathingActivity(string activityName, string activityDescription,string FinalMessage) : base(activityName, activityDescription, FinalMessage)
    {
        DateTime startTime = DateTime.Now;
        _freezeTime = startTime.AddSeconds(0);
    }

    public BreathingActivity(string activityName, string activityDescription, string FinalMessage, int freeztime) : base(activityName,activityDescription, FinalMessage)
    {
        string freezTimeString = freeztime.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _freezeTime = startTime.AddSeconds(int.Parse(freezTimeString));
    }

    //-----Getter and Setters --------
    public DateTime Getfreezetime()
    {
        return _freezeTime;
    }

    public void SetTime(DateTime settedFreeze)
    {
        string freezTimeString = settedFreeze.ToString().PadRight(3,'0');
        DateTime startTime = DateTime.Now;
        _freezeTime = startTime.AddSeconds(int.Parse(freezTimeString));
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

                //If the user press 'Enter'
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter || currentTime < futureTime)
                {
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
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter || currentTime < futureTime)
                {
                    break;
                }

            }
        }
    }

    public int GetFreezeBreathAct(int seconds)
    {
        int sec1 = seconds;
        int sec2 = sec1;

        int remaining = seconds;
        bool toggle = true;
        string message = "Breath in...";
        int countDown = 3;
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText("");
        while (remaining > 0)
        {
            Console.Clear();

            //For each breathe loop
            while (countDown > 0 && remaining > 0)
            {
                Console.Clear();
                Console.WriteLine($"{message} {countDown}");

                Thread.Sleep(1000);

                //Rest 1 for each iteration
                countDown--;
                remaining--;

            }
            //Depends if the breathe is in or out
            if (message == "Breathe in...")
            {
                countDown = 6;
                Console.Clear();
            }
            if (message == "Now Breathe out...")
            {
                countDown = 3;
                Console.Clear();
            }

            //Change the state of the variable (if is true, change to false and reverse)
            toggle = !toggle;
            message = toggle ? "Breathe in..." : "Now Breathe out...";
        }

        //Return the quantity of seconds the user spend in this activity
        return sec1;
    }
}