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

            numbers.Add(numAdded);
        } 

        //Test to print list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }     
        
    }
}