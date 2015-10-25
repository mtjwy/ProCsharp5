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
            Parameter modifier:
                non, pass by value
                out, output parameters
                ref,
                params,
         */

        static int Main(string[] args)
        {
            int ansAdd = 0;
            int ansSub = 0;
            
            AddSubstract(1, 2, out ansAdd, out ansSub);

            Console.WriteLine(ansAdd);
            Console.WriteLine(ansSub);

            Console.ReadLine();
            return -1;
        }

        //The out modifier
        //output parameters must be assigned in the method implementation
        //use output parameters to get multiple outputs from a single method invocation
        static void AddSubstract(int x, int y, out int ansAdd, out int ansSub)
        {
            ansAdd = x + y;
            ansSub = x - y;
        }

       
    }
}
