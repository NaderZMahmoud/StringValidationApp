using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstTest = "(Hello)";
            string secondTest = "(Hello";
            string thirdTest = "Hello)";
            string forthTest = "Hello";
            string fifthTest = null;
            string sixthTest = ")(";
            string seventhTest = " ";

            Console.WriteLine(firstTest +":"+ validateString(firstTest));
            Console.WriteLine(secondTest + ":" + validateString(secondTest));
            Console.WriteLine(thirdTest + ":" + validateString(thirdTest));
            Console.WriteLine(forthTest + ":" + validateString(forthTest));
            Console.WriteLine(fifthTest + ":" + validateString(fifthTest));
            Console.WriteLine(sixthTest + ":" + validateString(sixthTest));
            Console.WriteLine(seventhTest + ":" + validateString(seventhTest));
            // Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
            
            
        }
        public static bool validateString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            // char[] chars = input..ToCharArray();
            int firstBarctes = 0;
            int secondBractes = 0;
            // bool? flag = null;
            foreach (char c in input)
            {
                if (c == '(')
                {
                    firstBarctes++;
                    // flag = false;
                }

                if (c == ')')
                {
                    secondBractes++;
                    if (secondBractes > firstBarctes)
                        return false;
                }
            }

            if (firstBarctes == 0 && secondBractes == 0)
                return false;

            return firstBarctes == secondBractes;
        }
    }
}
