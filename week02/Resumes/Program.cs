using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobtitle = "Software Engineer";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        Job Job2 = new Job();
        Job2._company = "Apple";
        Job2._jobtitle = "Manager";
        Job2._startYear = 2022;
        Job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "João Viana";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.Display();
    }
}