using System;
namespace JournalApp
{
    class Program

    {
      Journal journal = new Journal();
      
      
      static void Main(string[] args)
       {
      DisplayIntro();   
      RunMenu();
      GetRandomPrompt();
      LoadFromFile();
      SaveToFile();
      DisplayAll();
      
       }
       static  void DisplayAll()
      {

      }
       static private void RunMenu()
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
             SaveToFile();
             break;
         case "5":
         Environment.Exit(0);
         break;

        default:
        Console.WriteLine("Invalid choice. Please try again.");
            break;
            
        }
      } while ("choice" != "5");  
    }
    static private string GetChoice()
   {
      bool ischoiceValid = false;
      string choice = "";

            do
            {
               Write();
      
               Console.WriteLine("Welcome to the journal program");
              
               
               Console.WriteLine(" > 1.Write the journal.");
               Console.WriteLine(" > 2.Display the journal.");
               Console.WriteLine(" > 3.Load the journal.");
               Console.WriteLine(" > 4.Save the journal.");
               Console.WriteLine(" > 5.Quit.");
               Console.WriteLine("\n Please what would you like to do ?");

             
               choice = Console.ReadLine().Trim();
              

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

        static private void CreateJournalFile()
        {
           //WriteLine($"Does file exist? {File.Exists("Journal.txt)"}");
           if (!File.Exists("journey.txt"))
           {
                
           }

         }
         static private void DisplayIntro()
         {
          
           Write();
           Console.WriteLine(" welcome to the best journal App ever!");
           waitForkey();
         }
     
         static private void DisplayOutro()
         {
         
           Console.WriteLine("Thanks for using the journal App!");
           waitForkey();
         }
        static  private void waitForkey()
         {
       
           Console.WriteLine("\n press any key...");
        
         }
         Entry entry = new Entry();
         
         PromptGenerator prompt = new PromptGenerator();

        static  private void DisplayjournalContents()
         {
          
            Console.WriteLine("\n === journey Contents===");
            Console.WriteLine("=================");
            waitForkey();
         }

          static private void GetRandomPrompt()
           {
            
           }
            static public void LoadFromFile()
             {
              Console.Write("Enter the filename to load the journal: ");
              string filename = Console.ReadLine();

             }
        static private void Write()
          {
          
           Console.WriteLine("\n journal Written");
           waitForkey();
          }

         static private void LoadEntry()
           {
             
             Console.WriteLine("\n What would you like to Load: ");
             
            //String newline = Console.ReadLine();
             
            
            Console.WriteLine("The journal has been modified!");
             //waitForkey();
            Console.Write("Enter the filename to load the journal: ");
            string filename = Console.ReadLine();

            using (StreamReader reader = new StreamReader(filename))
           {
            while (!reader.EndOfStream)
              {
              Entry entry = new Entry();
            
            entry._promptText = reader.ReadLine();
            entry._entryText  = reader.ReadLine();
            }

            }

           }  
         static private void SaveToFile()
         
           {
          
          
             Console.WriteLine("\n What would you like to Save:? ");
             
             String newline = Console.ReadLine();
             
            
             Console.WriteLine("The journal has been modified!");
             waitForkey();
             using (StreamWriter writer = new StreamWriter("filename"))
            {
        //foreach (Entry entr in Entries)
             {
          //  writer.WriteLine(entry._date);
           // writer.WriteLine(entry._promptText);
           // writer.WriteLine(entry._entryText);
        }
            }

           
           
           
           }
    
      }
    
}