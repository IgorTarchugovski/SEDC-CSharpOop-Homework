using System;

namespace Homework.CSharpOop.Class02.Task01.RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - "RealCalculator"

            /*
            Create new console application “RealCalculator” that takes two numbers from the input
            and asks what operation would the user want to be done( +, - , * , / ). 
            Then it returns the result.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the Operation: +
            Expected Output:
            The result is: 25
            */

            #endregion

            Console.WriteLine("Enter first number: ");
            string userInput1 = Console.ReadLine();
            int num1 = int.Parse(userInput1);

            Console.WriteLine("Enter second number: ");
            string userInput2 = Console.ReadLine();
            int num2 = int.Parse(userInput2);

            Console.WriteLine("Enter the operation: (+, -, *, /)");
            string operation = Console.ReadLine();


            if (operation == "+")
            {
                int sum = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            }
            else if (operation == "-")
            {
                int sub = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + sub);
            }
            else if (operation == "*")
            {
                int multiplication = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + multiplication);
            }
            else if (operation == "/")
            {
                int division = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + division);
            }

            Console.ReadLine();
        }
    }
}
