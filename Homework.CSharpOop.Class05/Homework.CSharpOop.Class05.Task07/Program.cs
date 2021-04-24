using System;

namespace Homework.CSharpOop.Class05.Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 7
            /*
                Task 7:
                Create a function to find the number of times a substring appears in a given string.
            */
            #endregion
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a substring: ");
            string word = Console.ReadLine();

            Console.WriteLine($"The substring \"{word}\" appears \"{CheckOccurrences(text, word)}\" times in the string \"{text}\".");

            static int CheckOccurrences(string str, string subStr)
            {
                int count = 0;
                int a = 0;
                while ((a = str.IndexOf(subStr, a)) != -1)
                {
                    a += subStr.Length;
                    count++;
                }
                return count;
            }

            Console.ReadLine();
        }
    }
}