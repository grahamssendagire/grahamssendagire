

// Base class representing a mindfulness Activity
public abstract class Activity
{
   //Adding member variables to the class as public members 
   public string Name{get;set;}
   public string Description{get;set;}
   
    // create a constructor 
    public Activity(string name,string description)
    {
       Name = name;
       Description = description;
      
    }
    //Add the method for GetName to return the name of each Activity.
    public string GetName()
    { 
        return Name;
    }
    // Add the method for GetDescription to return the description of each Activity. 
    public string GetDescription()
    {
        return Description;
    }
     // Add an abstracted method to perform the Activity.
     public abstract void RunActivity(int durationInSeconds);
     

}    




