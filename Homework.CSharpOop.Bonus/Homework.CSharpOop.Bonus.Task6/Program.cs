using System;

namespace Homework.CSharpOop.Bonus.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task6
            /*
                Task 6:
                Write a program that will find out the sum of all numbers that divide 5 in the range 1-N (N is input from keyboard). 
            */
            #endregion

            Console.Write("Enter a mumber: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int n);

            int sum = 0;

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 5 == 0)
                    {
                        sum = sum + i;
                        Console.WriteLine((sum - i) + " + " + (i) + " = " + (sum));
                    }
                }
                Console.WriteLine($"The sum of numbers devidable by 5 from 1 to {n} is: {sum}");
            }

            Console.ReadLine();
        }
    }
}
