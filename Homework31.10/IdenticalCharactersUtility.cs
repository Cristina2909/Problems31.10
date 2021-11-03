using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Check if a String Contains only Identical Characters
//Write a function that returns true if all characters in a string are identical and false otherwise.

namespace Homework31._10
{
    public static class IdenticalCharactersUtility
    {
        public static void VerifyIfTheyLettersAreIdentical()
        {
            Console.WriteLine("Please enter the word you want to verify");
            var wordName = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < wordName.Length - 1; i++)
            {
                if (wordName[i] == wordName[i + 1])
                {
                    counter = counter + 1;
                }
            }
            
            if (counter == wordName.Length - 1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
