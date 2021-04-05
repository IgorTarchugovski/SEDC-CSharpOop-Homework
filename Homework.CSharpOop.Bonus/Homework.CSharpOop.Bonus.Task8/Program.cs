using System;

namespace Homework.CSharpOop.Bonus.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task8
            /*
                Task 8:
                Write a program that will read two arrays from console input. 
                Then the program has to make a comparison of the arrays and determine whether they are equal or not. 
                { 1, 2, 3, 4 } == { 1, 2, 3, 4 } { 1, 2, 3, 4 } != { 2, 1, 3, 4 }
            */
            #endregion

            Console.Write("Enter the length of the arrays you want to compare: ");
            string userInput = Console.ReadLine();
            bool isValid = Int32.TryParse(userInput, out int n);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number");
            }


            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            bool isEqual = true;


            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Array 1 item {i+1}: ");
                arr1[i] = Console.ReadLine();
            }

            Console.WriteLine("=======================");

            for (int i = 0; i < arr2.Length; i++)
            {               
                Console.Write($"Array 2 item {i+1}: ");
                arr2[i] = Console.ReadLine();
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isEqual = false;
                }
            }

            Console.WriteLine("=======================");

            if (isEqual)
            {
                Console.WriteLine("The arrays are equal");
                
            }
            else
            {
                Console.WriteLine("The arrays are NOT equal");
            }
            
            Console.ReadLine();
        }
    }
}
