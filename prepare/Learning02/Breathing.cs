// Derived class representing a breathing Activity.
public class Breathing: Activity

{
   //Declaring a Constructor for the derived class breating.
   public Breathing(string name,string description) : base(name,description)
    {
     
    }
   // Implementation of RunActivity method for breathing
    public override void RunActivity(int durationInSeconds)
    {
        Console.WriteLine ($"Starting {Name}:");
        Console.WriteLine(Description);
        // Keep waiting before the activity starts.
        Console.WriteLine("Get ready to start breathing activity--------/n");
        // Wait for 2 seconds before starting activity.
        Thread.Sleep(2000);

        for (int i = 1; i <= durationInSeconds; i++)
         {
           Console.WriteLine($"Breath in-----{durationInSeconds}");
           //pause for a second before continueing
           Thread.Sleep(1000);

           Console.WriteLine($"Breath in-----{durationInSeconds}");
           //pause for a second before continueing
           Thread.Sleep(1000);
           // Display Completion Message
           Console.WriteLine($"\n Completed {Name}.\n" );
         }  

    }
}