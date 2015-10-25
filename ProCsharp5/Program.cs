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
            //processing any incoming args
            foreach(string arg in args)
            {
                Console.Write("Arg: {0}", arg);
            }
            Console.ReadLine();
            return -1;
        }
    }
}
