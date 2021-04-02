using System;

namespace Homework.CSharpOop.Class03.Task01.SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - "SumOfEven"
            /*
             Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print
            the sum of the even numbers from the array:
            Test Data:
                Enter integer no.1: 4
                Enter integer no.2: 3
                Enter integer no.3: 7
                Enter integer no.4: 3
                Enter integer no.5: 2
                Enter integer no.6: 8
            Expected Output:
                The result is: 14
                
             */

            #endregion

            Console.WriteLine("\"SUM OF EVEN NUMBERS\"");

            int[] arr = new int[6];

            Console.Write("Enter integer no.1: ");
            string userInput1 = Console.ReadLine();
            int no1 = int.Parse(userInput1);
            arr[0] = no1;

            Console.Write("Enter integer no.2: ");
            string userInput2 = Console.ReadLine();
            int no2 = int.Parse(userInput2);
            arr[1] = no2;

            Console.Write("Enter integer no.3: ");
            string userInput3 = Console.ReadLine();
            int no3 = int.Parse(userInput3);
            arr[2] = no3;

            Console.Write("Enter integer no.4: ");
            string userInput4 = Console.ReadLine();
            int no4 = int.Parse(userInput4);
            arr[3] = no4;

            Console.Write("Enter integer no.5: ");
            string userInput5 = Console.ReadLine();
            int no5 = int.Parse(userInput5);
            arr[4] = no5;

            Console.Write("Enter integer no.6: ");
            string userInput6 = Console.ReadLine();
            int no6 = int.Parse(userInput6);
            arr[5] = no6;

            int sum = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    sum = sum + num;
                }
            }

            if (sum % 2 != 0 || sum == 0)
            {
                Console.WriteLine("You did not enter an even number!");
            }

            Console.WriteLine("The sum of the even numbers from the array: " + sum);

            Console.Read();
        }
    }
}
