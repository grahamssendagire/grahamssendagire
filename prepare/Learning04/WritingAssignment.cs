
// Create the class and set up the inheritance relationship.

public class WritingAssignment: Assignment
{
    private string _title;
    // set up a constructor and set its member variables.
    public WritingAssignment(string studentName,string title,string topic): base(studentName,topic)
    {
     //Here we stick to only one varriables since the two have been passed dirrectly to the base class 
     //Here we set any variables specific to the WritingAssignment class
           _title = title;
    }
//Add the method GetTittle and return the title.
//Add the method GetWritingInformation
    public string GetTitle()
    {
     return _title;
    }
    public string GetWritingInformation()
    {
    // Notice that we are calling the getter here because _studentName is private in the base class
    string studentName = GetStudentName();
     return  ($" {_title} by {studentName}");
    }
}   
