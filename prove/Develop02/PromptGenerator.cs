using System;

public class PromptGenerator

{
   // initializing the list to avail the prompts in the program 
    public List<string> _prompts = new List<string>(){"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"}; 
    
   
    
 public string RandomSelection()
       {
        Random Interresting  = new Random();
        int size = _prompts.Count();
        return _prompts[Interresting.Next(1,size)];
       }
    
}
      