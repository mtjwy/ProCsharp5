using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        static class
            When designing a utility class, it is good practice to apply the static keyword to the class definition.
            
            static class can only contain static members. 
     */

    // static class can only contain static members. 
    static class TimeUtil
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }

        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }
}
