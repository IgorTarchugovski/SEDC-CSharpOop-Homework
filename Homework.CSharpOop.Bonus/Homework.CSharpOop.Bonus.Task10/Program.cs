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
                Write a program that will find out all numbers in the range [1 : 1000] that divide the product composed of their digits.
             */
            #endregion

            int temp = 0;
            for (int i = 0; i < 1000; i++)
            {
                long product = 1;
                int n = temp;
                while (n != 0)
                {
                    product = product * (n % 10);
                    n = n / 10;
                }
                Console.WriteLine(i);
            }
            





            /*            for (int i = 1; i <= 100; i++)
                        {

                            long product = 1;
                            int temp = i;

                            if (temp % product == 0)
                            {
                                int n = temp;
                                while (n != 0)
                                {
                                    product = product * (n % 10);
                                    n = n / 10;
                                }

                            }
                            Console.WriteLine(temp);
                        }*/


            Console.ReadLine();
        }
    }
}
