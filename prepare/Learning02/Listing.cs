
// Derived class representing listing activity
public class Listing : Activity
{
    // List of prompts for listing activity
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string name, string description) : base(name, description)
    {
    }

    // Implementation of PerformActivity method for listing
    public override void RunActivity(int durationInSeconds)
    {
        Console.WriteLine($"Starting {Name}:");
        Console.WriteLine(Description);

        Random random = new Random();

        // Select random prompt
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        // Pause for preparation
        Console.WriteLine("Get ready to start listing...\n");
        // Wait for 2 seconds before starting
        Thread.Sleep(2000); 

        // Perform listing exercise
        Console.WriteLine("Listing items:");
        for (int i = 1; i <= durationInSeconds; i++)
        {
            Console.WriteLine($"Item {i}");
            // Pause for user to list item
            Thread.Sleep(1000); // Pause for 1 second
        }

        // Display completion message
        Console.WriteLine($"\nCompleted {Name}. You listed {durationInSeconds} items.\n");
    }
}