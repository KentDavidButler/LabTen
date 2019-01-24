using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Validator
    {
        public static double IsValidDouble()
        {
            for(; ; )
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                Console.Write("That input isn't valid, Please type in a valid number:");
            }
        }

        public static bool YesOrNo()
        {
            string input;
            while (true)
            {
                Console.Write("(y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                }
            }
        }

    }
}
