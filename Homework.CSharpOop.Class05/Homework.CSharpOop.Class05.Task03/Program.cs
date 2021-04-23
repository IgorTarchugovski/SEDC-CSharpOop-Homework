using System;

namespace Homework.CSharpOop.Class05.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task3
            /*
                Task 3:
                Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.
             */
            #endregion

            int n;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter length of array: ");
                string arrLengthInput = Console.ReadLine();
                isValid = int.TryParse(arrLengthInput, out n);
                if (!isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid length numer!");
                    Console.ResetColor();
                    Console.Beep();
                }
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    bool isValidNum = false;
                    while (!isValidNum)
                    {
                        Console.Write($"No.{i + 1}: ");
                        isValidNum = int.TryParse(Console.ReadLine(), out int num);
                        if (!isValidNum)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a valid number!");
                            Console.ResetColor();
                            Console.Beep();
                        }
                        arr[i] = num;
                    }
                }

                Console.WriteLine("=========================");
                Console.WriteLine($"Greatest value in array is: {GreatestValue(arr)}");
            }

            // Function
            static int GreatestValue(int[] numArray)
            {
                int grtVal = 0;
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (numArray[i] > grtVal)
                    {
                        grtVal = numArray[i];
                    }
                }
                return grtVal;
            }












            /*           Console.Write("Enter length of array: ");
                       string arrLengthInput = Console.ReadLine();
                       bool isValid = int.TryParse(arrLengthInput, out int n);

                       if (!isValid)
                       {
                           Console.WriteLine("Please enter a valid length numer!");
                       }

                       int[] arr = new int[n];
                       for (int i = 0; i < n; i++)
                       {
                           Console.Write($"No.{i+1}: ");
                           bool isVlaidNum = int.TryParse(Console.ReadLine(), out int num);
                           if (!isVlaidNum)
                           {
                               Console.WriteLine("Please enter a valid number!");
                               Console.Beep();
                           }
                           arr[i] = num;               
                       }

                       Console.WriteLine("=========================");
                       Console.WriteLine($"Greatest value in array is: {GreatestValue(arr)}");


                       // Function
                       static int GreatestValue(int[] numArray)
                       {
                           int grtVal = 0;
                           for (int i = 0; i < numArray.Length; i++)
                           {
                               if (numArray[i] > grtVal)
                               {
                                   grtVal = numArray[i];
                               }
                           }
                           return grtVal;
                       }
           */
            Console.ReadLine();
        }
    }
}
