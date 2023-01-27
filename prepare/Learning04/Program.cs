using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asig1 = new Assignment("Samuel Bennet","Multiplication");
        string printi = asig1.GetSummary();
        Console.WriteLine(printi);

        MathAssignment asig2 = new MathAssignment("Roberto Rosdriguez","Fractions", "7.3", "8-19");
        Console.WriteLine(asig2.GetSummary());
        Console.WriteLine(asig2.GetHomeworkList());

        WritingAssignment asign3 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(asign3.GetSummary());
        Console.WriteLine(asign3.GetWritingInformation());
        
    }
}