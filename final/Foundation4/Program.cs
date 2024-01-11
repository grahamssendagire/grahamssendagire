using System;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 9.7));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
