using System;
// declaring the class name.
public class Resume
{
   public string _name;
   // initialise your list to a new list before you use it.
   public List<Job> _jobs =new List<Job>();

   public void Display()
   {
    Console.WriteLine($"name:{_name}");
    Console.WriteLine("Jobs:");

    foreach(Job job in _jobs)
    {
        // this will call the Display method on each of the Job.
        job.Diplay();
    }
   }
}