using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        static
            the memory of a static data is shared by all objects of that category.

            use static method to set or get static data.

            static data is perfect when you have a value that should be common to all objects of that category. 

            
     */
    class SavingsAccount
    {
        // Instance-level data. 
        public double currBalance;

        // A static point of data. 
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
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
