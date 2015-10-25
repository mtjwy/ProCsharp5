using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    class Program
    {
        //Main method is private by default
        static int Main(string[] args)
        {
            //ShowEnvironmentDetails();
            objectFunctionality();
            dataTypeFunctionality();
            Console.ReadLine();
            return -1;
        }

        //use some methods in System.Environment
        static void ShowEnvironmentDetails()
        {
            foreach(String drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Driver: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("New line: {0}", Environment.NewLine);
            Console.WriteLine("System directory: {0}", Environment.SystemDirectory);
          
        }

        static void objectFunctionality()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                12.GetType(), 12.GetTypeCode(), 12.GetHashCode(), 12.ToString(), 12.Equals(12));
        }

        static void dataTypeFunctionality()
        {
            Console.WriteLine(double.Epsilon);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
        }
    }
}
