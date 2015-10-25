using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    class Program
    {
        /*
            Optional parameters
                The value assigned to an optional parameter must be known at compile time
                Optional parameters must always be put at the end of parameter list
            
            Named parameters
                named parameters and optional arguments tend to work hand in hand.
                named parameters allowed the called to specify only the parameters for which they
                do not wish to received the defaults.
         */
        static void Main(string[] args)
        {

            DisplayFancyMessage();
            DisplayFancyMessage(message: "Hello");
            Console.ReadLine();

        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue,
                                        ConsoleColor backgroundColor = ConsoleColor.White,
                                        string message = "Test Message")
        {
            // Store old colors to restore after message is printed. 
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Set new colors and print message. 
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Restore previous colors. 
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
