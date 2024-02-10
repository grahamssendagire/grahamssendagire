using System;

class Program
{
    static void main(string[] args)
    
      {
         // calling the methods and varriables from the job class:

         Job job1 = new Job();
         job1._jobTitle = "Software Engineer";
         job1._company = "Microsoft";
         job1._startYear = 2019;
         job1._endYear = 2022;
          
          Job job2 = new Job();
          job2._jobTitle = "Software Engineer";
          job2._company = "Microsoft";
          job2._startYear = 2022;
          job2._endYear = 2023;

          Resume myResume = new Resume();
     
           myResume._name = "Graham Ssendagire";
           myResume._jobs.Add(job1);
           myResume._jobs.Add(job2);
           myResume.Display();
      }   
}