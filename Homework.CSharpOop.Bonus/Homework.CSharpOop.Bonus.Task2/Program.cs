using System;

namespace Homework.CSharpOop.Bonus.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2
            /*
             Task 2:
             Write a program that will print out all numbers in the range 1-N (N is input from keyboard, N>5) that divide 2 and 3.
            */
            #endregion

            Console.Write("Enter a mumber: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int n);

            if (!isValid || n <= 5)
            {
                Console.WriteLine("Please enter a number bigger than 5");
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
