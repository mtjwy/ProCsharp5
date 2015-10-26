using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCsharp5
{
    /*
        .NET Properties
            encapsulate state data

        To streamline your code, and isolate all of your error checking to a 
        central location, you will do well if you alwaysuse properties within 
        your class whenever you need to get or set the values.

        read-only property: omit the set block
        write-only property: omit the get block
     */
    class Employee
    {
        // Field data. 
        private string empName;
        private int empID;
        private float currPay;

        // Properties! 
        //the 'string' represents the type of data this property encapsulates.
        public string Name
        {
            get { return empName; }//a get scope
            set//a set scope
            {
                if (value.Length > 15)// value is a contextual keyword, within the set scope of the property
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        // Constructors. 
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            // Better! Use properties when setting class data. 
            // This reduces the amount of duplicate error checks. 
            Name = name;
            ID = id;
            Pay = pay;
        }
    

        // Methods. 
        public void GiveBonus(float amount)
        {
            Pay += amount;//use properties
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);//use properties
            Console.WriteLine("ID: {0}", ID);//use properties
            Console.WriteLine("Pay: {0}", Pay);//use properties
        }
    }
}
