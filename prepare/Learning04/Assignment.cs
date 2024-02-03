// declaring the base class in csharp and Adding the attributes as private member variables.
class Assignment
{
      private string _studentName;
      private string _topic;
// Create a constructor for this class that receives a student name and topic and sets the member variables
      public Assignment(string studentName,string topic)
      {
             _studentName = studentName;
             _topic = topic;
      }
      // Add the method for GetStudentName() to return the student's name .
      public string GetStudentName()
      {
        return _studentName;
      }
      // Add the method for GetTopic() to return the Topic .
      public string GetTopic()
      {
        return _topic; 
      }
      // Add the method for GetSummary() to return the student's name and the topic.
      public string GetSummary()
      {
       return _studentName + " - " + _topic;
      }

}    
   
