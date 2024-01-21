using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

namespace JournalApp
{
    class Program
    {
      public void Run()
       {
        Title = "Journal App";
        DisplayIntro();
        DisplayjournalContents();
        createjournalFile();
        RunMenu();
        DisplayOutro();
        LoadEntry();
        Write();
        SavejournalContent();
        
       }
       private void RunMenu()
       {
       do
       {
         string choice = GetChoice();
         switch(choice)
         {
         case "1":
             Write();
             break;
         case "2":
             DisplayIntro();
             break;
         case "3":
            
             break;
         case "4":
             SavejournalContent();
             break;
         
        default:
            break;
        }
      } while ("choice" != "5");  
    }
    private string GetChoice()
   {
      bool ischoiceValid = false;
      string choice = "";

            do
            {
               Write();
      
               Console.WriteLine("Welcome to the journal program");
              
               Console.WriteLine("\n Please what would you like to do ?");
               Console.WriteLine(" > 1.Write the journal.");
               Console.WriteLine(" > 2.Display the journal.");
               Console.WriteLine(" > 3.Load the journal.");
               Console.WriteLine(" > 4.Save the journal.");
               Console.WriteLine(" > 5.Quit.");

             
               choice= ReadLine().Trim();
              

               if(choice== "1" || choice == "2" || choice =="3" || choice=="4" || choice== "5")
            {
                ischoiceValid = true;
            }
           else
           {
             
             Console.WriteLine($"\"{choice}\" is not a valid option.Please choose 1-5.");
             waitForkey();
           } 
           
        } while(!ischoiceValid);
           return choice;
        }

        private void createjournalFile()
        {
           //WriteLine($"Does file exist? {File.Exists("Journal.txt)"}");
           if (!File.Exists("journey.txt"))
           {
                
           }

         }
         private void DisplayIntro()
         {
          
           Write();
           Console.WriteLine(" welcome to the best journal App ever!");
           waitForkey();
         }
     
         private void DisplayOutro()
         {
         
           Console.WriteLine("Thanks for using the journal App!");
           waitForkey();
         }
         private void waitForkey()
         {
       
           WriteLine("\n press any key...");
        
         }
         private void DisplayjournalContents()
         {
            
           
            Console.WriteLine("\n === journey Contents===");
            Console.WriteLine("=================");
            waitForkey();
         }
            private void Write()
          {
          
           
           Console.WriteLine("\n journal Written");
           waitForkey();
          }

         private void LoadEntry()
           {
             
             WriteLine("\n What would you like to Load: ");
             
             String newline = ReadLine();
             
            
             WriteLine("The journal has been modified!");
             waitForkey();
           }
         private void SavejournalContent()
           {
          
             Console.WriteLine("\n What would you like to Save:? ");
             
             String newline = ReadLine();
             
            
             Console.WriteLine("The journal has been modified!");
             waitForkey();
           }
      }
    
}  