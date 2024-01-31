using System;
// declaring the class name
public class Job
{
    // Declaring of variables in the given Class.
  public string _jobTitle;
  public string _company;
  public int _startYear;
  public int _endYear;
  // include a method for Displaying the variables of the class and shouldnot be returning anything.
  public void Display()
  {
    // interpollation of the string with a varriable
        Console.WriteLine($"{_jobTitle}({_company}){_startYear}-{_endYear}");
  }

}
