using System;

namespace Homework.CSharpOop.Class04.Task1.FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /*
             Task 1
                Create a new method called FunWithStrings that will have one input parameter (string) and it will have no return
                In that method you should display in console the following tasks for the string:
                print the reverse string
                print total number of vowels
                check if string is palindrome
                print the largest word
                print the smallest word
                print the count of words
                print the most used character (not space obviously)
                Ask the user to enter a string and call the method with that string.
            */
            #endregion

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            static void FunWithStrings(string str)
            {
                // Reverse
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string revStr = new string(arr);
                Console.WriteLine($"Reversed string: {revStr}");

                // Total number of vowels
                int vowelCounter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (str[i] == 'a' ||
                        str[i] == 'e' ||
                        str[i] == 'i' ||
                        str[i] == 'o' ||
                        str[i] == 'u' ||
                        str[i] == 'A' ||
                        str[i] == 'E' ||
                        str[i] == 'I' ||
                        str[i] == 'O' ||
                        str[i] == 'U')
                    {
                        vowelCounter++;
                    }
                }
                Console.WriteLine($"Number of vowels: {vowelCounter}");


                // Palindrome
                bool palindrome = false;
                if (revStr == str)
                {
                    palindrome = true;
                }
                Console.WriteLine($"Palindrome: {palindrome}");


                // Largest word
                string[] splited = str.Split(" ");

                string largestWord = "";
                int temp = 0;
                foreach (String word in splited)
                {
                    if (word.Length > temp)
                    {
                        largestWord = word;
                        temp = word.Length;
                    }
                }
                Console.WriteLine($"Largest word: {largestWord}");


                // Smallest word
                string smallestWord = "";
                int temp2 = temp;
                foreach (String word2 in splited)
                {
                    if (word2.Length < temp2)
                    {
                        smallestWord = word2;
                        temp2 = word2.Length;
                    }
                }
                Console.WriteLine($"Smallest word: {smallestWord}");

                // Count of words
                long wordCounter = 0;
                foreach (string word in splited)
                {
                    wordCounter++;
                }
                Console.WriteLine($"Count of words: {wordCounter}");



                // Most used character
                int[] charCount = new int[256];
                for (int i = 0; i < arr.Length; i++)
                {
                    charCount[str[i]]++;
                }
                int maxCount = -1;
                char character = ' ';
                for (int i = 0; i < arr.Length; i++)
                {
                    if (maxCount < charCount[str[i]])
                    {
                        maxCount = charCount[str[i]];
                        character = str[i];
                    }
                }
                Console.WriteLine($"Most used character: {character}, ocurrences: {maxCount}");
            }

            FunWithStrings(str);





            Console.ReadLine();
        }
    }
}
