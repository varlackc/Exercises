/*
 *  Class: CSCI231.10396 
 *  Assingment: 9A
 *  Exercise: 5.42
 *  Author: Carlos Maxwell Varlack
 *  Description: This program encrypts a four digit integer
 *  Note: This assignment consist of two programs,
 *  one program encrypts the message and another program
 *  decrypts the message. (Per the specifications in 
 *  exercise 5.42)
 *  
*/

using System;
using System.Linq;

namespace Assignment9A_Exercise_5_42_Enc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int message = 1234;
            int[] encodedMessage; // declare an array this is done in case that the encoded message is a number with less than 4 digits

            // Explain the program to the user
            ExplainToUser();

            // Get The input from the user
            Console.Write("Insert the four digit number that you want to encrypt: ");
            message = int.Parse(Console.ReadLine());

            //Encrypt message
            encodedMessage = Encrypt(message);
            Console.Write("\nThe encoded message is ");

            //display the encripted message in the array
            for (int i = 0; i < 4; i++) {
                Console.Write(encodedMessage[i]);
            }

            // Wait untill the user desides to close the program
            Console.Read();
        }
        static int[] Encrypt(int fourDigits)
        {
            // Declare variables
            int tempHold = 0;

            // Modify the integer to an array of integers
            int[] digits = fourDigits.ToString().Select(num => Convert.ToInt32(num) - 48).ToArray();// use linq to modify the integer to array 
            // and use 48 as a correction factor. 

            // Add seven to each integer in the array
            for (int i = 0; i < 4; i++)
            {
                digits[i] = (digits[i] + 7);
            }

            // Apply the Modulus 10 to each element in the array
            for (int i = 0; i < 4; i++)
            {
                digits[i] = (digits[i] % 10);
            }

            // Swap the position of the elements in the array
            tempHold = digits[0];
            digits[0] = digits[2];
            digits[2] = tempHold;
            tempHold = digits[1];
            digits[1] = digits[3];
            digits[3] = tempHold;

            // Modify the array to a final integer that will be returned
            //result = (digits[0] * 1000) + (digits[1] * 100) + (digits[2] * 10) + (digits[3]);

            // Return result
            return digits;
        }

        static int Decrypt(int encryptedMessage)
        {
            // Declare variables
            int inputLength, additionalZeros, tempHold;
            int result = 0;
            int[] digits = new int[4]; // declare integer array of size 4

            // Convert the encryptend message to an array
            int[] initialDigits = encryptedMessage.ToString().Select(num => Convert.ToInt32(num) - 48).ToArray(); //use linq to modify the integer to array

            //Get the length of the input
            inputLength = encryptedMessage.ToString().Length;

            // determine if additional zeros need to be added
            additionalZeros = 4 - inputLength;

            //if additional zeros are needed then add the zeros 
            if (additionalZeros > 0 && additionalZeros < 4)
            {
                // add the additional zeros
                for (int i = 0; i < additionalZeros; i++)
                {
                    digits[i] = 0;
                }
                // add the rest of the digits
                for (int i = additionalZeros; i < 4; i++)
                {
                    digits[i] = initialDigits[i - additionalZeros];
                }
            }

            //Swap the position of the elements in the array
            tempHold = digits[0];
            digits[0] = digits[2];
            digits[2] = tempHold;
            tempHold = digits[1];
            digits[1] = digits[3];
            digits[3] = tempHold;

            //Revert the changes made to the encription process
            for (int i = 0; i < 4; i++)
            {
                // if the digit is smaller than seven then add three
                if (digits[i] < 7)
                {
                    digits[i] = digits[i] + 3;
                }
                // if the digit is greater or equal to seven then substract seven
                else
                {
                    digits[i] = digits[i] - 7;
                }
            }

            //Modify the array to a final integer that will be returned 
            result = (digits[0] * 1000) + (digits[1] * 100) + (digits[2] * 10) + (digits[3]);

            return result;
        }


        static public void ExplainToUser()
        {
            Console.WriteLine("\t**********************************************");
            Console.WriteLine("\t* This program encrypts a four digit number  *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t* Exercise 5.42                              *");
            Console.WriteLine("\t*                                            *");
            Console.WriteLine("\t**********************************************");
            Console.WriteLine();
        }


    }
}
