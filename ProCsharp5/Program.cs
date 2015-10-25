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

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("Information about {0}:", e.ToString());
            Console.WriteLine("Type: {0}", e.GetType());//get enum type
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));//get storage type

            //Get all name/value pairs
            Array enumData = Enum.GetValues(e.GetType());

            Console.WriteLine("This enum has {0} members.", enumData.Length);
            //Console.WriteLine("Type of array item: {0}",enumData.GetValue(0).GetType());

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));//use the d format flag
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            //GetBonusByEmployeeType(Employee1.VicePresident);
            //GetBonusByEmployeeType(Employee1.Contractor);

            Employee1 emp = Employee1.VicePresident;
            EvaluateEnum(emp);

            DayOfWeek day = DayOfWeek.Sunday;
            EvaluateEnum(day);

            ConsoleColor cc = ConsoleColor.Black;
            EvaluateEnum(cc);

            Console.ReadLine();

        }

        
    }
}
