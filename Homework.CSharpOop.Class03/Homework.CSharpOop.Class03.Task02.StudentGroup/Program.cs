using System;

namespace Homework.CSharpOop.Class03.Task02.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2 - "StudentGroup"

            /*
            Make a new console application called StudentGroup
            Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            Get a number from the console between 1 and 2 and print the students from that group in the console.
            Ex: stidentsG1 ["Zdavko", "Petko", "Stanko", "Branko", "Trajko"]
            Test Data:
                Enter student group: (there are 1 and 2)
                    1
            Expected Output:
                The students in G1 are:
                Zdravko
                Petko
                Stanko
                Branko
                Trajko
            */

            #endregion

            Console.WriteLine("\"Student Group\"");

            string[] studentsG1 = { "Igor", "Ana", "Filip", "Marija", "Goran" };
            string[] studentsG2 = { "Kristina", "Marko", "Nikola", "Marija", "Lile" };

            Console.Write("For G1 enter 1, for G2 enter 2: ");

            string opt = Console.ReadLine();
            if (opt == "1")
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string name in studentsG1)
                {
                    Console.WriteLine(name);
                }
            }
            else if (opt == "2")
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string name in studentsG2)
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                Console.WriteLine("Please enter 1 or 2");
            }

            Console.Read();
        }
    }
}
