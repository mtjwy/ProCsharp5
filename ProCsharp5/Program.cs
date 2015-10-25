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
            ShowEnvironmentDetails();
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
    }
}
