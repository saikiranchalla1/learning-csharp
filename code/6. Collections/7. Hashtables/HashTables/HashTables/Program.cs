using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();



            //Console.WriteLine("Hello World!");

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 76);



            //Adding data to the hashtable
            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student1);

            //Fetching data from teh hashtaboe.


            Student storedStudent1 = (Student)studentsTable[1]; // make sure to cast to the right tab.

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);


            // Looping over HashTable data

            foreach(DictionaryEntry entry in studentsTable)
            {
                Student student = (Student)entry.Value;

                Console.WriteLine("Student ID: {0}:", student.Id);
                Console.WriteLine("Student Name: {0}", student.Name);
            }

            Console.ReadLine();

        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}

