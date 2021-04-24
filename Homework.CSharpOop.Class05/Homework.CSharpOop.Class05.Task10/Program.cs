using System;

namespace Homework.CSharpOop.Class05.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 10
            /*
            Task 10:
            Create a function that takes a number as an argument and returns an array of numbers counting down from this number to zero.
            5 -> [5, 4, 3, 2, 1, 0] 
            */
            #endregion

            Console.Write("Countdown from number: ");
            int input = int.Parse(Console.ReadLine());
            int[] CdArr = CountDown(input);
            foreach (int num in CdArr)
            {
                Console.WriteLine(num);
            }

            static int[] CountDown(int num)
            {
                int n = num + 1;
                int[] arr = new int[n];               
                for (int i = 0; i < n; i++)
                {
                    arr[i] = i;
                }
                Array.Reverse(arr);
                return arr;
            }

            Console.ReadLine();
        }
    }
}
