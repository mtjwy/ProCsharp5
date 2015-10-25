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
         */
        static void Main(string[] args)
        {

            printLog("Null pointer!");

            printLog("File not found!", "file system");
            Console.ReadLine();
            
        }

        static void printLog(string message, string owner = "Progmmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

       


    }
}
