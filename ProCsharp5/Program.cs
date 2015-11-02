﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    class Program
    {
        /*
            Bugs: These are errors made by the programmer.

            User errors: caused by the individual running the application.

            Exceptions

            Exception object wrap the error’s name, a descriptive message, and other 
            helpful information about this error condition. as well as a detailed snapshot 
            of the call stack that triggered the exception in the first place. 

            exceptions should be thrown only when a terminal condition has been met 
            (for example, not finding a necessary file, failing to connect to a database, and 
            the like). Deciding exactly what justifies throwing an exception is a design issue 
            you must always contend with.



         */

        static void Main(string[] args)
        {

            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            // Speed up past the car's max speed to 
            // trigger the exception.

            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            // The error has been handled, processing continues with the next statement. 
            Console.WriteLine("\n***** Out of exception logic *****");

            Console.ReadLine();
            
        }

    }
}
