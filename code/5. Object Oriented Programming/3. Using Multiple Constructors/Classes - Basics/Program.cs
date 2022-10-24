using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human("Denis", "Panjuta", "green", 29);
            denis.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
