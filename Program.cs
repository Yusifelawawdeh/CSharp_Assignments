using System;

namespace Treehouse
{
    class Program
    {
        static void Main()
        { 
            int runningTotal = 0; 
            bool keepGoing = true;
          
            while(keepGoing)
            {
              
              // prompt user for minutes of exercise
              Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
            
              string entry = Console.ReadLine();
                
                if (entry == "quit") 
                {
                  keepGoing = false;
                }
                else 
                {
              
              int minutes = int.Parse(entry);
                       
              // add minutes via input for da running total\
              runningTotal = runningTotal + minutes;
            
              // display total minutes exercised
              Console.WriteLine("You've exercised " + runningTotal + " minutes");
            
              // repeat until user quits
                  
                }
              
            }
          
            Console.WriteLine("GoodDay sir !");
        }
    }
}
