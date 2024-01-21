using System;

class Program
{
    static void Main(string[] args)
    
    {
        Journal theJournal = new Journal();

        List<Entry>entries = new List<Entry>();
        
        Entry anEntry = new Entry();
        
        anEntry.Display();
    }
}