using System;


public abstract class activity
{
   public string Name{get;set;}
   public string Description{get;set;}
    public int Duration {get;set;}
    public abstract void RunActivity();
}
