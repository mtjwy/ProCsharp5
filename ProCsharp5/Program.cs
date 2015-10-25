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
            Passing Reference Types by Reference
               If a reference type is passed by reference, 
               the callee can change the object the original reference is referencing.      
         */

        //pass by ref
        static void SendAPersonByReference(ref Person p)
        {
            // Change some data of "p". 
            p.personAge = 555;

            // "p" is now pointing to a new object on the heap! 
            p = new Person("Nikki", 999);
        }

        class Person
        {
            public string personName;
            public int personAge;
            // Constructors. 
            public Person(string name, int age)
            {
                personName = name;
                personAge = age;
            }
            public Person() { }
            public void Display()
            {
                Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Passing Person object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before passing by ref call, Person is:");
            mel.Display();

            Console.WriteLine();

            // Passing ref-types by ref
            SendAPersonByReference(ref mel);
            Console.WriteLine("After passing by ref call, Person is:");
            mel.Display();

            Console.ReadLine();


            Console.ReadLine();

        }


    }
}
