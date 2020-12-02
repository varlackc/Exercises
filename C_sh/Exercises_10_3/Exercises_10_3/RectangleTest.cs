/*
 10.3 (Rectangle Class) Create class Rectangle. 
 The class has attributes length and width, each of which defaults to 1. 
 It has read-only properties that calculate the Perimeter and the Area of the rectangle. 
 It has properties for both length and width. 
 
 The set accessors should verify that length and width are each floating-point numbers 
 greater than 0.0 and less than 20.0. Write an app to test class Rectangle.
 */

using System;

namespace Exercises_10_3
{
    class RectangleTest
    {
        static void Main(string[] args)
        {

            //declare variables
            float length = (float) 5.0;
            float width = (float) 5.0;

            // Explain the program to the user
            ExplainToUser();

            // Display the parameters
            DisplayParameters(length, width);

            // Declare new invoice object
            Rectangle sampleRectangles = new Rectangle(length, width);

            // Desplay the result
            Console.WriteLine(" Perimeter: "+sampleRectangles.Perimeter());
            Console.WriteLine(" Area: " + sampleRectangles.Area());

            Console.ReadLine();
        }

        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t =======================================");
            Console.WriteLine("\t| Rectangle Test Application \t\t|");
            Console.WriteLine("\t =======================================");
            Console.WriteLine();
        }

        //Show the parameters to the user
        public static void DisplayParameters( float length, float width)
        {
            Console.WriteLine("\t Length: " + length);
            Console.WriteLine("\t Width: " + width);
            Console.WriteLine();
        }
    }
}
