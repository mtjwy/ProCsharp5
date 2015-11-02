using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


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

            Exception properties:

            The TargetSite Property
                TargetSite return a strongly typed System.Reflection.MethodBaseobject

            The System.Exception.StackTrace property 
                allows you to identify the series of calls that resulted in the exception.

            The HelpLink Property

            The Data Property
                The Data property returns an object implementing the interface IDictionary.
                key/value pairs data
                


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
            // TargetSite actually returns a MethodBase object. 
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                // By default, the data field is empty, so check for null. 
                Console.WriteLine("\n-> Custom Data:");
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }

            // The error has been handled, processing continues with the next statement. 
            Console.WriteLine("\n***** Out of exception logic *****");

            Console.ReadLine();
            
        }

    }
}
