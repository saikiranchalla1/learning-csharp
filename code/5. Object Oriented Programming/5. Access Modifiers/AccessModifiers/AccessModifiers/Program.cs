using System;

namespace AccessModifiers
{
    class NumberClass
    {
        //private int number = 10;
        //public int number = 10;

        protected int number = 10; //we can access this variable inside this class
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberClass num = new NumberClass();
            //Console.WriteLine(num.number); // Error. We can't access the number variable because 
            // it has the private access modifier and its only accessible in the NumberClass class


            //Console.WriteLine(num.number); // This is OK. The number variable has the public access modifier.

             //Console.WriteLine(num.number); // Error. The number variable is inaccessible due to its protection level. 
                                           // The Program class doesn't derive from the NumberClass


        }
    }

    class DerivedClass : NumberClass //this is inheritance. DerivedClass derives from the NumberClass class
    {
        void Print()
        {
            Console.WriteLine(number); //we can access it in this class as well because it derives from the NumberClass class
        }
    }


}

