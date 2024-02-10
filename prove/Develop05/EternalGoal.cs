class EternalQuest
{
    private Dictionary<string, Goal> goals = new Dictionary<string, Goal>();
    private int score = 0;

    public void CreateGoal(string name, string type, int value, int? target = null)
    {
        if (!goals.ContainsKey(name))
        {
            goals[name] = new Goal(name, type, value, target);
            Console.WriteLine($"Goal '{name}' created successfully!");
        }
        else
        {
            Console.WriteLine("Goal with this name already exists!");
        }
    }

    public void RecordEvent(string name)
    {
        if (goals.ContainsKey(name))
        {
            goals[name].RecordEvent();
            score += goals[name].Value;
            Console.WriteLine($"Event recorded for goal: {name}");
        }
        else
        {
            Console.WriteLine("Goal not found!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Value.Name} - [{goal.Value.GetCompletionStatus()}]");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {score}");
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, goals);
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while saving goals: {e.Message}");
        }
    }

    public void LoadGoals(string filename)
    {
        try
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                goals = (Dictionary<string, Goal>)formatter.Deserialize(fs);
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while loading goals: {e.Message}");
        }
        catch (SerializationException e)
        {
            Console.WriteLine($"An error occurred while deserializing goals: {e.Message}");
        }
    }
}