using System;

namespace Homework.CSharpOop.Bonus.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*
             Task 1:
             Write a program that will print out all numbers from the range 1-N (N is input from keyboard, N>2) that divide with 3.
            */
            #endregion

            Console.Write("Enter a mumber: ");
            string userInput = Console.ReadLine();           
            bool isValid = Int32.TryParse(userInput, out int n);

            if (!isValid || n <= 2)
            {
                Console.WriteLine("Please enter a number bigger than 2");
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
