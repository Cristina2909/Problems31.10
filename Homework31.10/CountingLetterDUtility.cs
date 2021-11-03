using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// How Many D's Are There?
//Create a function that counts how many D's are in a sentence.

namespace Homework31._10
{
    public static class CountingLetterDUtility
    {
        public static void GetTheNumberofLetterD()
        {
            Console.WriteLine("Please enter the sentence in which yoy want to count letter D= ");
            var sentence = Console.ReadLine();

            int counter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if ( sentence[i] == 'd' || sentence [i] == 'D')
                {
                    counter = counter + 1;
                }

            }
            Console.WriteLine("In this sentence there are {0} letters of D", counter);

        }
    }
}
