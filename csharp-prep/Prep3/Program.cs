using System;


class Program
{
    static void Main(string[] args)
    {
     
      Console.Write("What is the magic number?");
      string answer1 = Console.ReadLine();
      int magicNumber = int.Parse(answer1);
       Random randomandomGenerator = new Random();
        magicNumber = randomandomGenerator.Next(1, 101);

        int guess = -1;
      
      if (magicNumber < guess) 
       {
        Console.WriteLine("Higher");
       }
      else if (magicNumber > guess)
       {
        Console.WriteLine("Lower");
       }
      else
       {
        Console.WriteLine("You guessed it !");
       }

    }    
}