/*
 Carlos Maxwell Varlack

13.10 (FormatExceptions) Create an app that inputs miles driven and gallons used, 
and calculates miles per gallon. The example should use exception handling to process 
the FormatExceptions that occur when converting the input strings to doubles. 
5If invalid data is entered, display a message informing the user.

 */

using System;

namespace Exercise_13_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonsUsed = 0;

            try {

                // Explain the program to the user
                ExplainToUser();

                Console.WriteLine("Please enter the miles driven: ");
                milesDriven = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter gallons used: ");
                gallonsUsed = Convert.ToDouble(Console.ReadLine());

                double milesPerGallon = milesDriven / gallonsUsed;
                Console.WriteLine("Mileage is " + milesPerGallon + " miles per gallon.");

                Console.ReadLine();

            }
            catch (FormatException e)
            {
                Console.WriteLine("There is a format error. ", e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("An Error has occurred", e.Message);
            }

        }


        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t ===============================================");
            Console.WriteLine("\t| Mileage Application \t\t|");
            Console.WriteLine("\t ===============================================");
            Console.WriteLine();
        }

    }
}
