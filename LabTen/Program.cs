using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountCircles = 0;
            do
            {
                Console.WriteLine("Welcome to the Cicle Tester");
                Console.Write("Enter Radius: ");
                Circle firstCircle = new Circle(Validator.IsValidDouble());
                Console.WriteLine("");

                Console.Write("Circumference:");
                Console.WriteLine(firstCircle.CalculateFormattedCircumference());
                Console.Write("Area: ");
                Console.WriteLine(firstCircle.CalculatedFormattedArea());
                Console.WriteLine("Continue?");
                amountCircles++;
            } while (Validator.YesOrNo());
            Console.WriteLine("Goodbye. You created " + amountCircles + " Circle object(s).");
        }
    }
}
