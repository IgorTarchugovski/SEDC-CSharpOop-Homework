using System;

namespace Homework.CSharpOop.Class02.Task03.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 3 - "SwapNumbers"
            /*
            Create new console application “SwapNumbers”. 
            Input 2 numbers from the console and then swap the values of the variables so that the first 
            variable has the second value and the second variable the first value. Please find example below:
            Test Data:
            Input the First Number: 5
            Input the Second Number: 8
            Expected Output:
            After Swapping:
            First Number: 8
            Second Number: 5
             */

            #endregion

            Console.Write("Input the First Number: ");
            string userInput1 = Console.ReadLine();
            int num1 = int.Parse(userInput1);

            Console.Write("Input the Second Number: ");
            string userInput2 = Console.ReadLine();
            int num2 = int.Parse(userInput2);

            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter Swapping:");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);


            Console.ReadLine();
        }
    }
}
