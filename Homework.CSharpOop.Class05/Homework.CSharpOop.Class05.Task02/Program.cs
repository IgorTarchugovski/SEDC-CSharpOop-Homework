using System;

namespace Homework.CSharpOop.Class05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task02
            /*
                Task 2:
                Create a function to say whether a string is symmetric (a palindrome). For example, "RADAR" is a palindrome.

             */
            #endregion
            Console.Write("Enter a word to check if it's palindrome: ");
            string userInput = Console.ReadLine();

            Palindrome(userInput);



            static void Palindrome(string inputStr)
            {
                char[] word = inputStr.ToUpper().ToCharArray();
                Array.Reverse(word);
                string revWord = new string(word);

                bool isPalindrome = inputStr.Equals(revWord, StringComparison.OrdinalIgnoreCase);

                if (isPalindrome == true)
                {
                    Console.WriteLine($"\"{inputStr}\" is a palindrome");
                }
                else
                {
                    Console.WriteLine($"\"{inputStr}\" is not a palindrome");
                }
            }



            Console.ReadLine();
        }
    }
}
