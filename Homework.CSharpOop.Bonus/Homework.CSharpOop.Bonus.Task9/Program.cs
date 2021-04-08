using System;

namespace Homework.CSharpOop.Bonus.Task9
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task9
            /*
                Task 9:
                Write a program that will find all numbers in between 1 and 1000, that divide the sum composed of their digits.
             */
            #endregion

            static void isDivisible(long n)
            {
                long temp = n;

                int sum = 0;
                while (n != 0)
                {
                    int k = (int)n % 10;
                    sum += k;
                    n /= 10;
                }

                if (temp % sum == 0)
                    Console.WriteLine($"{temp} : ({temp} / {sum} = {temp/sum})");

            }

            for (int i = 1; i <= 1000; i++)
            {
                isDivisible(i);
            }
                
            
            Console.ReadLine();
        }     
    }
}