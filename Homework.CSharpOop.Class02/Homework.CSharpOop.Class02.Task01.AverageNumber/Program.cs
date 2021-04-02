using System;

namespace Homework.CSharpOop.Class02.Task01.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2 - “AverageNumber”
            /*
                Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
                Test Data:
                Enter the First number: 10
                Enter the Second number: 15
                Enter the third number: 20
                Enter the four number: 30
                Expected Output:
                The average of 10, 15, 20 and 30 is: 18
             */
            #endregion

            Console.Write("Enter the First number: ");
            string userInput1 = Console.ReadLine();
            int num1 = int.Parse(userInput1);

            Console.Write("Enter the Second number: ");
            string userInput2 = Console.ReadLine();
            int num2 = int.Parse(userInput2);

            Console.Write("Enter the Third number: ");
            string userInput3 = Console.ReadLine();
            int num3 = int.Parse(userInput3);

            Console.Write("Enter the Fourth number: ");
            string userInput4 = Console.ReadLine();
            int num4 = int.Parse(userInput4);

            int average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + " is: " + average);


            Console.ReadLine();
        }
    }
}
