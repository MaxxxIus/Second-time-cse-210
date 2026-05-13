using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "microsoft";
        job1._jobTitle = "Coder";
        job1._startYear = 2010;
        job1._endYear = 2015;


        Job job2 = new Job();
        job2._company ="Apple";
        job2._jobTitle = "secretary";
        job2._startYear = 2005;
        job2._endYear = 2010;


        Resume resume1 = new Resume();
        resume1._name = "Freddy Fazbear";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();


    }
}