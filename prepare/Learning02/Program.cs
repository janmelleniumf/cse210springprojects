using System;

class Program
{
    static void Main(string[] args)
    {
        // This portion is the job information
        Job job1 = new Job();
        job1._jobTitle = "Subject Matter Expert";
        job1._company = "Aetna";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Database Admin";
        job2._company = "Greenstreet";
        job2._startYear = 2023;
        job2._endYear = 2027;

        // calling the name 
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        //adding the jobs on the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJob();
    }
}