using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean userInput = false;

        while (userInput == false)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choise from the menu: ");
            string input = Console.ReadLine();

            if (input == "4")
            {
                break;
            }
        }
    }
}