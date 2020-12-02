/*
 *  Class: CSCI231.10396 
 *  Assingment: Assignment 11
 *  Exercise: 6.12
 *  Author: Carlos Maxwell Varlack
 *  Description: This program displays the product of odd integers from 
 *  one to seven
 *  
 *  
*/


using System;

namespace Assignment11_Exercise_6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int min = 1;
            int max = 7;
            int result = 1;

            // Explain the program to the user
            ExplainToUser();

            // Loop from minimum integer upto and including the largest integer 
            for (int i = min; i <= max; i++)
            {
                //if the value is odd then update the result
                if (i % 2 == 1)
                {
                    result *= i;
                }

            }

            // Show the output to the user
            Console.WriteLine("The Result of multiplying the odd integers from "+min+" to "+max+" is "+result);

            //Wait until the user desides to quit the program
            Console.ReadLine();
        }

        // This method explains the program to the user
        static public void ExplainToUser()
        {
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t* This program gets multiplies the odd       *");
            Console.WriteLine("\t* integers from 1 to 7                       *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t* Exercise 6.12                              *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
        }
    }
}
