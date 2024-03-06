using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Health Care Aide";
        job1._company = "Alberta Health Services";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Licensed Practical Nurse";
        job2._company = "Alberta Health Services";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Job job3 = new Job();
        job3._jobTitle = "Registered Nurse";
        job3._company = "Alberta Health Services";
        job3._startYear = 2020;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Yukari Hall";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}