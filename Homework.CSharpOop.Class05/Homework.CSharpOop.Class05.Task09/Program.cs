using System;

namespace Homework.CSharpOop.Class05.Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 9
            /*
             Task 9:
                Create a function to take one parameter n to display the date of past n years from current date and to tell what day it was. 
                The parameter should not be larger that 20.
            */
            #endregion

            Console.Write("Enter how many years you want to go back to see the date: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(DateNYearsFromNow(num));

            static string DateNYearsFromNow(int n)
            {
                if (n > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "Number of years should not be larger that 20.";
                }

                DateTime todaysDate = DateTime.Now;
                DateTime pastNYears = todaysDate.AddYears(-n);
                string formatedDate = string.Format("{0:dd/MM/yyyy}", pastNYears);
                return $"\"{n}\" years ago the date was {formatedDate} and it was {pastNYears.DayOfWeek}";
            }
            Console.ReadLine();
        }
    }
}
