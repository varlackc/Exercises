/*
 *  Class: CSCI231.10396 
 *  Assingment: Assignment 12 
 *  Exercise: 6.13
 *  Author: Carlos Maxwell Varlack
 *  Description: This program displays the result of the factorial 
 *  of five. 
 *  
 *  In case of factorials for large numbers an arithmetic overflow will occur. 
 *  
*/


using System;

namespace Assignment12_Exercise_6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int max = 5;
            int result = 1;

            // Explain the program to the user
            ExplainToUser();

            // Help create the table
            Console.WriteLine("\t/------------------------------------\\");
            Console.WriteLine("\t| Value of N | Facturial of N        |");
            Console.WriteLine("\t|------------------------------------");


            // Loop from minimum integer upto and including the largest integer 
            for (int i = 1; i <= max; i++)
            {
                // Calculate the factorial
                result *= i;
                Console.WriteLine("\t|     "+i+"      |           "+result+"          |");

            }
            Console.WriteLine("\t\\------------------------------------/");

            //Wait until the user desides to quit the program
            Console.ReadLine();
        }

        // This method explains the program to the user
        static public void ExplainToUser()
        {
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t* This program calculates the factorial      *");
            Console.WriteLine("\t* up to the integer 5.                       *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t* Exercise 6.13                              *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
        }
    }
}
