using System;

namespace Homework.CSharpOop.Class05.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 12
            /*
            Create a function that goes through the array,
            incrementing (+1) for each odd number and decrementing (-1) for each even number and returns that array.
            [1, 2, 3, 4, 5] -> [2, 1, 4, 3, 6] 
            */
            #endregion

            int[] inputArr = new int[] { 1, 2, 3, 4, 5 };

            foreach (int num in IncrementOddDecrementEven(inputArr))
            {
                Console.WriteLine(num);
            }
            

            static int[] IncrementOddDecrementEven(int[] arr)
            {
                int[] newArr = new int[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    if (arr[i] % 2 != 0)
                    {
                        newArr[i] = arr[i] + 1;
                    }
                    else
                    {
                        newArr[i] = arr[i] - 1;
                    }
                }
                return newArr;
            }

            Console.ReadLine();
        }
    }
}
