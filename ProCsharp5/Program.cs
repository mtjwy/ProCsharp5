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
            enum
                enum is used to create a set of symbolic names that map to known numerical values
         */


        enum Employee1
        //default underlying storage type of enum is int
        //enum Employee: Byte //--> set underlying storage type to Byte
        {
            Manager,      // = 0
            Grunt,        // = 1
            Contractor,   // = 2
            VicePresident // = 3

        }

        //begine with 100
        enum Employee2
        {
            Manager = 100,      
            Grunt,        // = 101
            Contractor,   // = 102
            VicePresident // = 103

        }

        //Elements of enumeration need not be sequential!
        enum Employee3
        {
            Manager = 100,
            Grunt = 3,        
            Contractor = 39,   
            VicePresident = 20

        }

        static void GetBonusByEmployeeType(Employee1 e)
        {
            switch (e)
            {
                case Employee1.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case Employee1.Grunt:
                    Console.WriteLine("You have got to be kidding ... ");
                    break;
                case Employee1.Contractor:
                    Console.WriteLine("You already get enough cash ...");
                    break;
                case Employee1.VicePresident:
                    Console.WriteLine("Very good! Sir!");
                    break;
            }
        }

        static void Main(string[] args)
        {

            GetBonusByEmployeeType(Employee1.VicePresident);
            GetBonusByEmployeeType(Employee1.Contractor);
            Console.ReadLine();

        }

        
    }
}
