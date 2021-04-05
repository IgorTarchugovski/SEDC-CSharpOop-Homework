using System;

namespace Homework.CSharpOop.Bonus.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task4
            /*
                Task 4:
                Write a program that will find out the sum of all even numbers in the range 1-N (N is input from keyboard). 
            */
            #endregion

            Console.Write("Enter a mumber: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int n);

            int sumOfEven = 0;

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {                        
                        sumOfEven = sumOfEven + i;
                        Console.WriteLine((i-2) + " + " + (i) + " = " + (sumOfEven));
                    }
                }
                Console.WriteLine($"The sum of even numbers from 1 to {n} is: {sumOfEven}");
            }



            Console.ReadLine();
        }
    }
}
