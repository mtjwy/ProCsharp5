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
                params, a method only support single params argument. it must be the final argument in the parameter list.
         */

        static int Main(string[] args)
        {
            //pass double values directly
            Console.WriteLine("Average = {0} ", Average(1.0, 2.0, 3.0, 4.0, 5.0));

            //pass array
            double[] data = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            Console.WriteLine("Average = {0} ", Average(data));

            //Average of 0 is 0! 
            Console.WriteLine(Average());

            Console.ReadLine();
            return -1;
        }

        //The params modifier
        static double Average(params double[] values)
        {
            Console.WriteLine("Your send me {0} doubles.", values.Length);
            if (values.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            foreach (double d in values)
            {
                sum += d;
            }
            return sum / values.Length;
        }


    }
}
