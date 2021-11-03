using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//FizzBuzz Interview Question
//Create a function that takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz"

namespace Homework31._10
{
    public static class MultipleUtility
    {
        public static void GetTheOutputOfTheMultiple()
        {
            Console.WriteLine("Please write the number for which you want the output= ");
            var numberValue = Console.ReadLine();

            var isConverted = int.TryParse(numberValue, out int numberConverted);

            if (!isConverted)
            {
                throw new Exception("The number is not valid, please type another one= ");
            }


            if (numberConverted % 3 == 0 && numberConverted % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (numberConverted % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
           
            else if (numberConverted % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("{0}", numberConverted);
            }

        }
    }
}
