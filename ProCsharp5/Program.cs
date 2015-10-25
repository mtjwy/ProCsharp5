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
                ref, pass by reference
                params,
         */

        static int Main(string[] args)
        {
            string s1 = "flip";
            string s2 = "flop";

            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);      

            Console.ReadLine();
            return -1;
        }

        //The ref modifier
        //pass by reference, used to change the values declared in the caller's scope (sorting, swapping routine)
        static void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

       
    }
}
