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
            Nullable Types
                use ? suffix to make a value type to be a nullable type
                System.Nullable<T> 
                
                In C#, the ?suffix notation is a shorthand for creating an instance 
                of the generic System.Nullable<T> structure type.  
                         
         */
        static void LocalNullableVariables()
        {
            // Define some local nullable variables. 

            int? nullableInt = 10;
            //Nullable<int> nullableInt = 10;

            double? nullableDouble = 3.14;
            //Nullable<double> nullableDouble = 3.14;

            bool? nullableBool = null;
            //Nullable<bool> nullableBool = null;

            char? nullableChar = 'a';
            //Nullable<char> nullableChar = 'a';

            int?[] arrayOfNullableInts = new int?[10];
            //Nullable<int>[] arrayOfNullableInts = new int?[10];

            // Error! Strings are reference types! 
            // string? s = "oops"; 
        }

        class DatabaseReader
        {
            //Nullable data field
            public int? numericValue = null;
            public bool? boolValue = true;

            //return type is Nallable
            public int? GetIntFromDatabase()
            {
                return numericValue;
            }

            public bool? GetBoolFromDatabase()
            {
                return boolValue;
            }

        }

        static void Main(string[] args)
        {
            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");
            }

            bool? b = dr.GetBoolFromDatabase();
            if (b.HasValue)
            {
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined.");
            }


            Console.ReadLine();

        }


    }
}
