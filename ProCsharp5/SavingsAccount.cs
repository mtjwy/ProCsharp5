using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        static constructor
            when the value of static data is not known at compile time. (e.g., you need to 
            read in the value from an external file, a database, generate a random number)
            Can use a static constructor to obtain the value for static data at runtime.

            1. only a single static constructor per class. static construtor 
               can not be overloaded. 
            2. static constructor has no access modifier, has no parameters.
            3. static constructor execute only one time.
            4. the runtime invoke the static constructor when it creates a instance of the class,
               or before accessing the first static member.     
     */
    class SavingsAccount
    {
        // Instance-level data. 
        public double currBalance;

        // A static point of data. 
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // A static constructor! 
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        // Static members to get/set interest rate. 
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
