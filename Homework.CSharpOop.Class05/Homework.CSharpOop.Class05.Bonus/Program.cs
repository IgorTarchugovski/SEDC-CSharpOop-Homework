using System;

namespace Homework.CSharpOop.Class05.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bonus Task
            /*
            Make a method called AgeCalculator
            The method will have one input parameter, your birthday date
            The method should return your age
            Show the age of a user after he inputs a date
            Note: take into consideration if the birthday is today, after or before today
            */
            #endregion

            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter your Birth date (mm.dd.yyyy): ");
                isValid = DateTime.TryParse(Console.ReadLine(), out DateTime userInput);
                if (!isValid || userInput > DateTime.Today)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid date format! (mm.dd.yyyy), (mm-dd-yyyy), (mm/dd/yyyy)");
                    Console.ResetColor();
                    Console.Beep();
                }
                else
                {
                    Console.WriteLine($"You are {AgeCalc(userInput)} years old.");
                    if ((DateTime.Today.Month == userInput.Month) && (DateTime.Today.Day == userInput.Day))
                    {
                        Console.WriteLine("Happy Birthday!");
                    }
                }
            }


            static int AgeCalc(DateTime inputDate)
            {
                DateTime currentDate = DateTime.Now;
                int currentDay = currentDate.Day;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                int inputDay = inputDate.Day;
                int inputMonth = inputDate.Month;
                int inputYear = inputDate.Year;

                int age = currentYear - inputYear;

                if (inputMonth > currentMonth)
                {
                    age -= 1;
                }
                if (inputMonth == currentMonth && inputDay > currentDay)
                {
                    age -= 1;
                }
                return age;
            }

            Console.ReadLine();
        }
    }
}
