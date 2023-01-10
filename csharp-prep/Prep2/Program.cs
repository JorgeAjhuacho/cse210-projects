using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string gradeLetter = "";
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            gradeLetter = "B";
        }
        else if (grade >=70 && grade < 80)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else 
        {
            Console.WriteLine("You'll do better the next time.");
        }

    }
}