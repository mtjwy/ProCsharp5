using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        Using this to do Chaining Constructor Calls
            To reduce validation logic in constructors. A cleaner approach is to designate 
            the constructor that takes the greatest number of arguments as the “master constructor” 
            and have its implementation perform the required validation logic. The remaining 
            constructors can make use of the this keyword to forward the incoming arguments to the 
            master constructor and provide any additional parametersas necessary. In this way, 
            you only need to worry about maintaining a single constructor for the entire class, 
            while the remaining constructors are basically empty.  
        In .NET 4.0 or higher, another approach is to use an Optional Arguments master constructor     
     */
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        /*
        //constructor chaining 
        public Motorcycle() { }
        public Motorcycle(int intensity) : this(intensity, "") { }
        public Motorcycle(string name) : this(0, name) { }

        // This is the 'master' constructor that does all the real work.
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        */

        // Single constructor using optional args. 
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

    }
}
