using System;
using System.Collections;
using System.Collections.Generic;

namespace OtherCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }


            // STACKS

            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            // QUEUE
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadKey();


            // BIT ARRAYS
            //creating two  bit arrays of size 8
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);

            byte[] a = { 60 };
            byte[] b = { 13 };

            //storing the values 60, and 13 into the bit arrays
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            //content of ba1
            Console.WriteLine("Bit array ba1: 60");

            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6} ", ba1[i]);
            }
            Console.WriteLine();

            //content of ba2
            Console.WriteLine("Bit array ba2: 13");

            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6} ", ba2[i]);
            }
            Console.WriteLine();
            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();
            ba3 = ba1.Or(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after OR operation: 61");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

