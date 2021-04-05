using System;

namespace Homework.CSharpOop.Bonus.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task5
            /*
                Task 5:
                Write a program that will find out the sum of all odd numbers in the range 1-N (N is input from keyboard). 
            */
            #endregion

            Console.Write("Enter a mumber: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int n);

            int sumOfOdd = 0;

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        sumOfOdd = sumOfOdd + i;
                        Console.WriteLine((sumOfOdd-i) + " + " + (i) + " = " + (sumOfOdd));
                    }
                }
                Console.WriteLine($"The sum of even numbers from 1 to {n} is: {sumOfOdd}");
            }



            Console.ReadLine();
        }
    }
}
