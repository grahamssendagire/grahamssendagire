using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
class Program
{
  static void Main(string[] args)
    {
        EternalQuest quest = new EternalQuest();
        quest.CreateGoal("Run a marathon", "simple", 1000);
        quest.CreateGoal("Read scriptures", "eternal", 100);
        quest.CreateGoal("Attend the temple", "checklist", 50, 10);

        quest.RecordEvent("Run a marathon");
        quest.RecordEvent("Read scriptures");
        quest.RecordEvent("Attend the temple");
        quest.RecordEvent("Attend the temple");

        quest.DisplayScore();
        quest.DisplayGoals();

        // Save and load goals
        quest.SaveGoals("goals.dat");

        EternalQuest newQuest = new EternalQuest();
        newQuest.LoadGoals("goals.dat");
        newQuest.DisplayGoals();
    }
}