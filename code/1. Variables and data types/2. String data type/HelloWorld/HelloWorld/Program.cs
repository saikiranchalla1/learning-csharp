using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string myname = "Denis";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();
    

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
        
    }
}
