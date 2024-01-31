// declare variables and then initialise to zero
using System.Collections;

static void main(string[] args)
 {
 int num1 = 0; int num2 = 0;
 // Display tittle as the C# Console Calculator App.
 Console.WriteLine("Console Calculator in C#\r");
 Console.WriteLine("----------\n");
 // Ask the user to type the first number.
 Console.WriteLine("Type a number,and then press Enter");
 num1 = Convert.ToInt32(Console.ReadLine());
 // Ask the user to type the second number.
 Console.WriteLine("Type another number,and then press Enter");
 num2 = Convert.ToInt32(Console.ReadLine);
  // Ask the user to Choose an option.
 Console.WriteLine("Choose an option from the following list:");
 Console.WriteLine("\ta-Add");
 Console.WriteLine("\ts-Subtract");
 Console.WriteLine("\tm-Multiply");
 Console.WriteLine("\td-Divide");
 Console.Write("Your Option?");
}
// switch statement to do math
switch(Console.ReadLine());
{
    Case "a":
    Console.WriteLine($"Your result:{num1}+{num2} =" + (num1+num2));
    break;
    Case "s":
    Console.WriteLine($"Your result:{num1}-{num2} =" + (num1-num2));
    break;
    Case"m":
    Console.WriteLine($" Your result: {num1}*{num2}="+(num1*num2));
    break;
    Case "d":
    Console.WriteLine($"Your result:{num1}/{num2}="+(num1/num2));
    break;
}
// wait for the user to respond before closing.
Console.WriteLine("Progress any key to close the calculator Console app---");
Console.ReadKey();