using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//H4ck3r Sp34k
//Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
//In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.

namespace Homework31._10
{
    public static class CodedString
    {
        public static void GetTheCodedWord()
        {
            Console.WriteLine("Please write the string you want to be coded= ");
            var wordValue = Console.ReadLine();
            var newString = wordValue.Replace("a", "4").Replace("e", "3").Replace("s", "5").Replace("i", "1");

            Console.WriteLine("The coded word is {0}", newString);
        }
    }
}
