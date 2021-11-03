using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework31._10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //IdenticalCharactersUtility.VerifyIfTheyLettersAreIdentical();
                //CodedString.GetTheCodedWord();
                //MultipleUtility.GetTheOutputOfTheMultiple();
                CountingLetterDUtility.GetTheNumberofLetterD();
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was an unexpected error! " + ex.Message);
            }
        }
    }
}
