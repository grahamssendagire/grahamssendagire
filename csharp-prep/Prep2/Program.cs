using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int x = int.Parse(gradePercentage);
        if (x>=90)
        {
            Console.WriteLine("Your grade is A ");
        }
        else if  (x>=80)
        {
            Console.WriteLine("Your grade is B ");
        }
        else if  (x>=70)
        {
            Console.WriteLine(" Your grade is C ");
        }
          else if  (x>=60)
        {
            Console.WriteLine(" Your grade is: D ");
        }
        else 
        {
            Console.WriteLine(" Your grade is: F ");
        }
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