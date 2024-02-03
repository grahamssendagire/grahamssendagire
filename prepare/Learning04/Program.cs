using System;

class Program
{
    static void Main(string[] args)

    {    // Create a base "Assignment" object.
        // Create a simple assignment, call the method to get the summary, and then display it to the screen.(create a base assignment object)
        Assignment assignment1 = new Assignment("Samuel Bennett","Multiplication");
        
        Console.WriteLine(assignment1.GetSummary());
    }
}
 