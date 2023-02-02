using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean userInput = false;

        void ShowSpinnerWithText(string text, string position = "left")
        {
            string activityName = text;
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            if (position == "left")
            {
                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("| " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("/ " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("— " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("\\ " + activityName);

                    Thread.Sleep(500);

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

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " /");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " —");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " \\");

                    Thread.Sleep(500);

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

        while (userInput != true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choise from the menu: ");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breatheActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Final Message");
                    Console.WriteLine(breatheActivity.PrintActivityName());
                    Console.WriteLine();
                    Console.WriteLine(breatheActivity.PrintActivtyDescription());
                    Console.WriteLine();
                    string durationStringBreathe = breatheActivity.PrintActivityDuration();
                    int durationNumberBreathe = int.Parse(durationStringBreathe);
                    //Save the variable as a copy (to use the cooldown without affect the original)
                    int copyOfDurationBA = durationNumberBreathe;
                    Console.Clear();
                    breatheActivity.GetFreezeBreathAct(copyOfDurationBA);
                    //Final output (reset the value of the activity's duration)
                    breatheActivity.SetActDuration(durationNumberBreathe);
                    Console.WriteLine(breatheActivity.GetFinalMessage());
                    ShowSpinnerWithText("");
                    Console.Clear();
                    break;
                case "4":
                    userInput = true;
                    break;
            }

        }

    }
}