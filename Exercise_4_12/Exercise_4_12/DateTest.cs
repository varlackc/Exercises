/*
 
 Write a test app named DateTest that demonstrates 
 class Date’s capabilities.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_12
{
    class DateTest
    {
        static void Main(string[] args)
        {
            //declare variables
            int day = 12;
            int month = 1;
            int year = 2020;

            // Explain the program to the user
            ExplainToUser();

            // Display the parameters
            DisplayParameters(month, day, year);

            // Declare new invoice object
            Date sampleDate = new Date(month, day, year);

            // Desplay the result
            sampleDate.DisplayDate();

            Console.ReadLine();
        }

        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t =======================================");
            Console.WriteLine("\t| Date Test Application \t\t|");
            Console.WriteLine("\t =======================================");
            Console.WriteLine();
        }

        //Show the parameters to the user
        public static void DisplayParameters(int month, int date,  int year)
        {
            Console.WriteLine("\t Month: " + month);
            Console.WriteLine("\t Day: " + date);
            Console.WriteLine("\t Year: " + year);
            Console.WriteLine();
        }
    }
}
