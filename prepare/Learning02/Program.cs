using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "INL";
        job1._startYear = 2013;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Teacher";
        job2._company = "BYU-I";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._userName = "Viola Hayes";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }   
}