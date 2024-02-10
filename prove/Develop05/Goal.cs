class Goal
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Value { get; set; }
    public int? Target { get; set; }
    public int Completed { get; set; }

    public Goal(string name, string type, int value, int? target = null)
    {
        Name = name;
        Type = type;
        Value = value;
        Target = target;
        Completed = 0;
    }

    public void RecordEvent()
    {
        if (Type == "simple" || Type == "eternal")
            Completed++;
        else if (Type == "checklist")
        {
            Completed++;
            if (Completed == Target)
                Completed += Value;
        }
    }

    public string GetCompletionStatus()
    {
        if (Type == "checklist")
            return $"Completed {Completed}/{Target} times";
        else
            return Completed > 0 ? "Completed" : "Not Completed";
    }
}
