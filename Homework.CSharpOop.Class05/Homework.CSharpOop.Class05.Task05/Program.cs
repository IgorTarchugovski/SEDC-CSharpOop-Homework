using System;

namespace Homework.CSharpOop.Class05.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 5
            /*
             Task 5:
                Create a function to read a sentence and replace lowercase characters by uppercase and vice-versa.
            */
            #endregion

            Console.WriteLine("Enter a sentence to replace lowercase characters by uppercase and vice-versa: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("===================================");
            Console.WriteLine($"Switched: \n{SwitchUpperAndLowerChar(sentence)}");

            static string SwitchUpperAndLowerChar(string text)
            {
                string switched = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLower(text[i]))
                    {
                        switched += char.ToUpper(text[i]);
                    }
                    else
                    {
                        switched += char.ToLower(text[i]);
                    }
                }
                return switched;
            }

            Console.ReadLine();
        }
    }
}
