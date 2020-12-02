/*
 *  Class: CSCI231.10396 
 *  Assingment: Assignment 10
 *  Exercise: 5.31
 *  Author: Carlos Maxwell Varlack
 *  Description: This program gets 10 positive integers from the user
 *  Then it displays the larger integer
 *  
*/

using System;

namespace Assignment10_Exercise_5_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int counter = 10;
            int number = 0;
            int largest = 0;

            // explain to the user
            ExplainToUser();
            Console.WriteLine("Insert 10 positive integers");

            // loop counter number of times
            for (int i = 0; i < counter; i++)
            {
                // get the input from the user
                Console.Write("Enter a positive integer: ");
                number = Convert.ToInt32(Console.ReadLine());

                //if the current integer is larger than the largest number then update
                if (number > largest)
                {
                    largest = number;
                }
            }

            //Print Results
            Console.WriteLine("\nThe largest number is "+largest);
            Console.Read();// wait until the user decides to quit
        }


        // This method explains the program to the user
        static public void ExplainToUser()
        {
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t* This program gets 10 positive integers     *");
            Console.WriteLine("\t* as inputs, the output will be the largest  *");
            Console.WriteLine("\t* integer in the input                       *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t* Exercise 5.21                              *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
        }
    }
}
