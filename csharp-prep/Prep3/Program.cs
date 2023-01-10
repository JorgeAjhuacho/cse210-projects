using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numberRandom = randomGenerator.Next(1, 51);
        
        int Number = -1;

        while (Number != numberRandom)
        {
            Console.Write("What is your guess? ");
            Number = int.Parse(Console.ReadLine());

            if (numberRandom > Number)
            {
                Console.WriteLine("Higher");
            }
            else if (numberRandom < Number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed. Correct!");   
            }
        }
        
    }
}