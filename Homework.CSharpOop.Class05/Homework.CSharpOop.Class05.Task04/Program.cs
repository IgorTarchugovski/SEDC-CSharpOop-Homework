using System;

namespace Homework.CSharpOop.Class05.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 4
            /*
             Task 4:
                Create two functions that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains.
                It will accept one parameter parameter: the string that we want to search,
                Function 1 should return the number of digits, function 2 should return the number of vowels. Do not name them function1 and 2 :)
             */
            #endregion

            string text = "skwd9-net-05-oopcsharp";

            Console.WriteLine($"The text {text} has {NumberOfDigits(text)} digits and {NumberOfVowels(text)} vowels.");

            static int NumberOfDigits(string text)
            {
                int counter = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    bool isNumber = char.IsDigit(text[i]);
                    if (isNumber)
                    {
                        counter++;
                    }
                }
                return counter;
            }


            static int NumberOfVowels(string text)
            {
                string textLowerCase = text.ToLower();
                int counter = 0;
                for (int i = 0; i < textLowerCase.Length; i++)
                {
                    if (textLowerCase[i] == 'a' || 
                        textLowerCase[i] == 'e' || 
                        textLowerCase[i] == 'i' || 
                        textLowerCase[i] == 'o' || 
                        textLowerCase[i] == 'u')
                    {
                        counter++;
                    }
                }
                return counter;
            }



            Console.ReadLine();
        }
    }
}
