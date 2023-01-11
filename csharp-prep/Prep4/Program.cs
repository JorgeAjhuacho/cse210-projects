using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>(); //List created
        int numAdded = -1;  
        while (numAdded != 0 )  //Until numAdded =0, will continue the loop
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            numAdded = int.Parse(input);
            
            if (numAdded != 0)
            {
                numbers.Add(numAdded);
            }
        } 

        //Iterating and adding each value
        float sum = 0;
        float avg = 0;
        int numlarge = 0;
        int smallest = 1000;
        foreach (int number in numbers)
        {
            sum = number + sum;
            avg = avg +1;
            //The largest number
            if (number > numlarge)
            {
                numlarge = number;
            }
            //The smallest positive number
            if (number < smallest && number >0)
            {
                smallest = number;
            }
        }     
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count}");
        Console.WriteLine($"The largest number is: {numlarge}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}