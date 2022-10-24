using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602Class
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Human denis = new Human(29, "Denis", "Panjuta", "green");
            Human frank = new Human(35, "Frank", "TheTank", "awesome");
            denis.IntroduceOnceself();
            frank.IntroduceOnceself();
            Console.Read();
        }
    }
}
