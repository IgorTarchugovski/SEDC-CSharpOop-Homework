using System;

namespace Homework.CSharpOop.Class05.Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 6
            /*
            Task 6:
            Create a function to check whether a character is an alphabet or not and if so, go to check for the case (upper or lower). 
            */
            #endregion

            Console.WriteLine("Enter a character to check if it's an alphabet: ");
            char ch;
            ch = Console.ReadLine()[0];

            IsItAnAlphabet(ch);
            

            static void IsItAnAlphabet(char character)
            {
                if (char.IsLetter(character))
                {
                    if (char.IsUpper(character))
                    {
                        Console.WriteLine($"The character \"{character}\" is an alphabet and is uppercase.");                        
                    }
                    else
                    {
                        Console.WriteLine($"The character \"{character}\" is an alphabet and is lowercase.");
                    }
                }
                else
                {
                    Console.WriteLine($"The character \"{character}\" is NOT an alphabet.");
                }
            }

            Console.ReadLine();
        }
    }
}
