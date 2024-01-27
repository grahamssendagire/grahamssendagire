
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    { 
      //This helps to get the current date and time from the device's operating system.
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        // This will get the random prompt from class promptGenerator.
        PromptGenerator newPrompt= new PromptGenerator();
         newPrompt.GetRandomPrompt();

        Console.WriteLine($"Date: {DateTime.Now.ToString("MM/DD/YYY")}_prompt: {_promptText}");
        // Recieve the inputs from the user
        _entryText = Console.ReadLine();

    }
   
    
}