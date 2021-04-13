using System;

namespace Homework.CSharpOop.Class04.Task2.RemoveExtraSpaceChar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            /*
            Task 2
            Create a new method that will remove extra space characters
            Call the method with the following text: 
            The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         
            next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       
            above, then get yer pirate ipsum...own the high seas,    argh!
             */
            #endregion

            string str1 = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";

            static void RemoveExtraSpace(string str)
            {
                string[] trimedArr = { };
                string trimedStr;

                string[] splited = str.Split(' ');
                foreach (string word in splited)
                {
                    if (word.Length != 0)
                    {
                        Array.Resize(ref trimedArr, trimedArr.Length + 1);
                        trimedArr[trimedArr.Length - 1] = word;
                    }
                    //Console.WriteLine($"{word.Length} {word}");
                }
                trimedStr = string.Join(" ", trimedArr);

                Console.WriteLine(trimedStr);
            }



            RemoveExtraSpace(str1);

            Console.ReadLine();
        }
    }
}
