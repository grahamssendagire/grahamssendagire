// Derrived class declaring a Reflection Activity.
public class Reflection : Activity
{
    // List of readonly prompts and List of readonly Questions.
    private List<string>_prompts = new List<string> (){"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

    private List<string>_Questions = new List<string> (){ "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
    public Reflection(string name,string description) : base(name,description)
    {

    }
   // Operating/conducting the RunActivity Method
    public override void RunActivity(int durationInSeconds)
    {
        Console.WriteLine($"Starting {Name}:");
        Console.WriteLine(Description);
 // declaring an object on the random selection of the prompt and question
        Random random = new Random();

// Pause for preparation
        Console.WriteLine("Get ready to start reflection exercise...\n");
// Wait for 2 seconds before starting.
        Thread.Sleep(2000);

    
    // Perform reflection exercise
     for (int i = 1; i < durationInSeconds; )
        {
            // Display random prompt
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}")
              // Display random prompt
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");

            // Pause for user to reflect
            Console.WriteLine("Reflecting...\n");
            Thread.Sleep(3000); // Pause for 3 seconds

            // Display random questions
            foreach (string question in questions)
            {
                Console.WriteLine($"Question: {question}");
                // Pause for user to answer
                Console.WriteLine("Thinking...\n");
                // Pause for 4 seconds
                Thread.Sleep(4000); 
            }

            // Update elapsed time
            i += 8 * questions.Length; // 8 questions per reflection   
        }

        // Display completion message
        Console.WriteLine($"\nCompleted {Name}.\n");
    }

}

   