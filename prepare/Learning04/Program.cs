using System;

class Program
{
    static void Main(string[] args)

    { // Create a base "Assignment" object.
      // Create a simple assignment, call the method to get the summary, and then display it to the screen.(create a base assignment object)
        Assignment assignment1 = new Assignment("Samuel Bennett","Multiplication");
        
        Console.WriteLine(assignment1.GetSummary());
      // creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3","problem 8-9");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment2.GetSummary());
    }

}
 