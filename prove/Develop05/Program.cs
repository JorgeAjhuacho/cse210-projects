using System;

class Program
{
    static void Main(string[] args)
    {
        int userPoints = 0;
        int option = 0;

        bool completedSimpleGoal = false;
        List<Goal> listOfGoals = new List<Goal>();

        while (option != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {userPoints} points.");
            Console.WriteLine();
            Console.WriteLine("[1] Create a New Goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record Event");
            Console.WriteLine("[6] Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("[1] Simple Goal");
                    Console.WriteLine("[2] Eternal Goal");
                    Console.WriteLine("[3] Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    switch(goalOption)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount associated to this goal? ");
                            
                    }
            }
        }
    }
}