using System;

namespace Homework.CSharpOop.Bonus.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task3
            /*
                Task 3:
                Write a program, which will be calculating the product of the digits of an input number. 
            */
            #endregion

            Console.Write("Enter a number to return product: ");
            string userInput = Console.ReadLine();
            bool isValid = Int64.TryParse(userInput, out long n);

            if (!isValid)
            {
                Console.WriteLine("Please enter a number");
            }
            else
            {
                long product = 1;

                while (n != 0)
                {
                    product = product * (n % 10);
                    n = n / 10;
                }

                Console.WriteLine(product);
            }
            

            Console.ReadLine();
        }
    }
}
