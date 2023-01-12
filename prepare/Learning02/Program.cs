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

        //Setting instance 2 'job2'
        Job job2 = new Job();
        job2._jobTitle = "Network Engineer";
        job2._company = "Cisco";
        job2._startYear = 2015;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Gerald Johnson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}