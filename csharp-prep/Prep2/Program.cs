using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);
        string value = " ";
               
        if (x>=90)
        {
            value = "A";
        }
        else if  (x>=80)
        {
            value = "B";
        }
        else if  (x>=70)
        {
            value = "C";
        }
          else if  (x>=60)
        {
            value = "C";
        }
        else 
        {
            value = "C";
        }
        Console.WriteLine($"Your grade is: {value}");
        if (x>=70)
        {
            Console.WriteLine("Congratulations You Excelled! ");
        }
        else
        {
            Console.WriteLine("Oooooooh Dear,Sorry Try Again Next Time");
        }
    }

}