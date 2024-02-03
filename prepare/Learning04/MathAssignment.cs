// Create this class and make sure to specify that it inherits from the base Assignment class.
public class MathAssignment: Assignment
{
//Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
             private string _textbookSection;
             private string _problems;
 // Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
 // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
// it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor. 
             public MathAssignment(string studentName,string topic,string textbookSection,string problems): base(studentName,topic)
             { 
            // here we stick two only two varriables since the two have been passed dirrectly to the base class
                _textbookSection = textbookSection;
                _problems = problems;
             }        
            // Add the method for GetTextBookSection() to return the TextBookSection.
             public string GetTextBookSection()
             {
                return _textbookSection;
             }
             //Add the method for GetProblems() to return the Problems.
             public string GetProblems()
             {
                return _problems;
             }
            // Add the GetHomeworkList() method
            public string GetHomeworkList()
            {
                return _textbookSection + " " + _problems;
            }





}       
