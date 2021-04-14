using System;

namespace Homework.CSharpOop.Class05.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*
            Task 1:

            Write a function that will give stats about an integer number. The function should write the stats in console. The stats required are:

            Whats the value of the number
            How many digits the number has
            Is the number odd or even
            Is the number positive
            I.e. if the user enters the number 25, the response should be

            The number 25 is a 2 digit number, it's odd and it's a positive number. 
            */
            #endregion

            Console.Write("Enter an integer: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int num);
            if (!isValid)
            {
                Console.WriteLine("Please enter a number!");
            }

            IntegerStats(num);



            static void IntegerStats(int num)
            {

                int numLength = Math.Abs(num).ToString().Length;             
                string oddOrEven = "odd";
                string positiveNegative = "nor positive or negative";
                if (num % 2 == 0)
                {
                    oddOrEven = "even";
                }

                if (num > 0)
                {
                    positiveNegative = "positive";
                }
                else if (num < 0)
                {
                    positiveNegative = "negative";
                }

                Console.WriteLine($"The number {num} is a {numLength} digit number, is's {oddOrEven} and it's a {positiveNegative} number.");
            }






            Console.ReadLine();
        }
    }
}
