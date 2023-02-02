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
                    BreathingActivity breatheActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "You have completed another seconds of the Breathing Activity.");
                    Console.WriteLine(breatheActivity.PrintActivityName());
                    Console.WriteLine();
                    Console.WriteLine(breatheActivity.PrintActivtyDescription());
                    Console.WriteLine();
                    string timeStringBreathe = breatheActivity.PrintActivityDuration();
                    int NumberBreathe = int.Parse(timeStringBreathe);
                    //Save the variable as a copy (to use the cooldown without affect the original)
                    int copyDuration = NumberBreathe;
                    Console.Clear();
                    breatheActivity.GetFreezeBreathAct(copyDuration);
                    //Final output (reset the value of the activity's duration)
                    breatheActivity.SetActDuration(NumberBreathe);
                    Console.WriteLine(breatheActivity.GetFinalMessage());
                    ShowSpinnerWithText("");
                    Console.Clear();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listingAct = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Final Message");
                    ListingActivity listingAct1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Final Message");
                    listingAct1.AddtoList("What are the most fulfilling things you've done for yourself in the past 12 months?: ");
                    listingAct1.AddtoList("What are the event or experience that have made you feel most alive and connected to the world around you?: ");
                    listingAct1.AddtoList("What are things you love about your community or city?: ");
                    listingAct1.AddtoList("What is somethings you enjoy about yourself and your personality?: ");
                    listingAct1.AddtoList("Can you write something you are proud of accomplishing this week?: ");
                    listingAct1.AddtoList("What is something you are grateful with the Lord right now?: ");
                    List<string> listQuestions = new List<string> {};
                    listQuestions.AddRange(listingAct1.GetListPrompt());

                    Console.WriteLine(listingAct.PrintActivityName());
                    Console.WriteLine("");
                    Console.WriteLine(listingAct.PrintActivtyDescription());
                    Console.WriteLine("");
                    string duration2 =listingAct.PrintActivityDuration();
                    int durationNum =int.Parse(duration2);
                    int copy2 = durationNum;
                    listingAct.FreezeListingAct(copy2, listQuestions);
                    Console.WriteLine();

                    listingAct.SetActDuration(durationNum);
                    ShowSpinnerWithText("");
                    Console.WriteLine(listingAct.PrintFinalMessage());
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