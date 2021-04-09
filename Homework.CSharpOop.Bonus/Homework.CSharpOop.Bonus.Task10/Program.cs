using System;

namespace Homework.CSharpOop.Bonus.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task10
            /*
            Task 10.
            Write a program that will find out all numbers in the range [1 : 1000] 
            that divide the product composed of their digits.
            */
            #endregion



            int n = 0;
            long product = 1;
            while (n != 0)
            {
                product = product * (n % 10);
                n = n / 10;
            }

                Console.WriteLine(product);
            

            for (int i = 1; i <= 100; i++)
            {
               
            }

            Console.ReadLine();
        }
    }
}
