using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    // this class is a blueprint for a datatype 

    // create a public variable lastName of type string.
    // change the IntroduceMyself method, so it tells the whole name.
    // create two objects with full information about themself - firstName and lastName
    
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // constructor
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;

        }


        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}",firstName, lastName);
        }
    }
}
