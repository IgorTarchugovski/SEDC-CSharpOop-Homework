using System;

namespace Homework.CSharpOop.Class05.Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 8
            /*
            Task 8:
            Create a function to take one parameter n and calculate what day of the week is n days from this moment. 
            */
            #endregion

            Console.WriteLine("What day of the week is n days from this moment?");
            Console.Write("Enter n: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("========================");
            Console.WriteLine($"{num} days from now it will be: {NDaysFromNow(num)}");

            static string NDaysFromNow(int n)
            {
                DateTime todaysDate = DateTime.Now;
                DateTime daysFromNow = todaysDate.AddDays(n);
                string formatedDate = string.Format("{0}, {1:dd/MM/yyyy HH:mm:ss}", daysFromNow.DayOfWeek, daysFromNow);
                return formatedDate;
            }

            Console.ReadLine();
        }
    }
}
