using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        Automatic Properties 
            Automatic properties must be read and write. it is notpossible to build 
            read-only or write-only automatic properties.

            Default Values: 0, false, null

            automatic properties never do more than provide simple encapsulation for 
            an underlyingpiece of (compiler-generated) private data. 

            Be aware, that if you are building a property that requires additional code 
            beyond getting and setting the underlying private field (such as data validation 
            logic, writing to an event log, communicating with a database, etc.), you will be 
            required to define a “normal” .NET property type byhand.
            
     */
    class Car
    {
        // Automatic properties! 
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
