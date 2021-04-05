using System;

namespace Homework.CSharpOop.Bonus.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task7
            /*
                Task 7:
                Write a program that will reverse the array {“a”,”b”,”c”,”d”} so that the output is {“d”,“c”,“b”,“a”}.
                - Do NOT use reverse array method :) 
            */
            #endregion

            char[] arr = { 'a', 'b', 'c', 'd' };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }


            Console.ReadLine();
        }
    }
}
