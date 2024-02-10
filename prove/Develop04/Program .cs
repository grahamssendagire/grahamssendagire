class Program
{
    static void Main(string[] args)
    {
        // Show the menu and let the user choose an activity
        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.Write("Enter your choice: ");
            }

            if (choice == 4)
                break;

            Console.Write("Enter duration in seconds: ");
            int durationInSeconds;
            while (!int.TryParse(Console.ReadLine(), out durationInSeconds) || durationInSeconds <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer value for duration.");
                Console.Write("Enter duration in seconds: ");
            }

            Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new Breathing("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                case 2:
                    activity = new Reflection("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;
                case 3:
                    activity = new Listing("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    break;
                default:
                    continue;
            }

            activity.RunActivity(durationInSeconds);
        }
    }
}