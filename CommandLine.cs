using System; // Using directive
              // Reduces the amount of typing you do for namespaces in rest of code
              
namespace Treehouse.FitnessFrog
{
  class Program
  {
      static void Main()
      {
          var runningTotal = 0.0;
        
          while (true)
          {
            // Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
            
            var entry = Console.ReadLine(); // Returns what the user typed back to the program. Str returned from method is stored in the entry var
         
            if (entry.ToLower() == "quit")
            {
              break;
            }
            
            try
            {
              var minutes = double.Parse(entry);
              if(minutes <= 0)
              {
                Console.WriteLine(minutes + " is not an acceptable value.");
              }
              else if(minutes <= 10)
              {
                Console.WriteLine("Better than nothing, am I right?"); 
              }
              else if(minutes <= 30)
              {
                Console.WriteLine("Way to go hot stuff!");
              }
              else if (minutes <= 60)
              {
                Console.WriteLine("You must be a ninja warrior in training!");
              }
              else
              {
                Console.WriteLine("Okay, now you're just showing off!");
              }
              
              // Add minutes exercised to total
              runningTotal += minutes;
              }
              catch(FormatException)
              {
                Console.WriteLine("That is not valid input.");
                continue;
              }
                
              // Display total minutes exercised to the screen; method to print to screen
              // OPTION 1 (BELOW)
                // Console.Write("You've entered ");
                // Console.Write(entry);
                // Console.WriteLine(" minutes");
            
              // OPTION 2 (BELOW) --> A lot more readable than the 3-method call above
              Console.WriteLine("You've entered " + runningTotal + " minutes.");
            
            // Repeat until the user quits
          }
            
          Console.WriteLine("Goodbye");
      }
   }
}
