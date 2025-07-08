using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Development";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2028;


        Job job2 = new Job();
        job2._jobTitle = "Software Engineering";
        job2._company = "Andela";
        job2._startYear = 2022;
        job2._endYear = 2029;


        Resume myResume = new Resume();
        myResume._name = "Jacob Amoah";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}