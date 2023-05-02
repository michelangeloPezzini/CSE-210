using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();
    job1._jobTitle = "Front-end Developer";
    job1._company = "Compass";
    job1._startYear = 2020;
    job1._endYear = 2023;

    Job job2 = new Job();
    job2._jobTitle = "Seller-marketplace";
    job2._company = "Apple";
    job2._startYear = 2008;
    job2._endYear = 2018;

    Resume myResume = new Resume();
    myResume._name = "Michelangelo Pezzini";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.DisplayResume();
  }
}