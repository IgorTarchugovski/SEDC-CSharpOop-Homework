using System;

namespace Homework.CSharpOop.Class05.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 11
            /*
             Task 11:
             Create a function that takes an array and returns the difference between the biggest and smallest numbers.
             [10, 4, 1, 4, -10, -50, 32, 21] -> 82
            */
            #endregion

            int[] inputArr = new int[] { 10, 4, 1, 4, -10, -50, 32, 21 };
            Console.WriteLine(DifferenceCalc(inputArr));

            static int DifferenceCalc(int[] arr)
            {
                int biggestNum = arr[0];
                int smallestNum = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > biggestNum)
                    {
                        biggestNum = arr[i];                       
                    }
                    if (arr[i] < smallestNum)
                    {
                        smallestNum = arr[i];
                    }
                }
                return biggestNum - smallestNum;
            }



            Console.ReadLine();
        }
    }
}
