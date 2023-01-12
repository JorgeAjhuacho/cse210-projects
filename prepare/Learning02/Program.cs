using System;

class Program
{
    static void Main(string[] args)
    {
        //Setting instance 1 'job1'
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Console.WriteLine(job1._company);
    }
}