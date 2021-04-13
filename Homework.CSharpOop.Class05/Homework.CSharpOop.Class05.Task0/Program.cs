using System;

namespace Homework.CSharpOop.Class05.Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task0
            //Create a function that calculates the result of raising an integer to another integer (eg 5 raised to 3 = 5^3 = 5 x 5 x 5 = 125).
            #endregion

            Console.Write("Enter number: ");
            string input1 = Console.ReadLine();
            bool isParsed = int.TryParse(input1, out int number);
            
            Console.Write("Enter exponent: ");
            string input2 = Console.ReadLine();
            bool isParsed2 = int.TryParse(input2, out int exponent);

            if (!isParsed || !isParsed2)
            {
                Console.WriteLine("Please enter an integer");
            }

            Console.WriteLine($"{number}^{exponent} = {PowFunc(number, exponent)}");

            static int PowFunc(int x, int y)
            {
                double val = Math.Pow(x, y);
                int res = Convert.ToInt32(val);
                return res;
            }




            Console.ReadLine();
        }
    }
}
