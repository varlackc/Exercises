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
    public class Rectangle
    {
        public float Length { get; set; } =  (float) 1.0;
        public float Width { get; set; } = (float) 1.0;

        // set parameters from 1.1 to 20.0
        public Rectangle(float length, float width)
        {
            if (length <= 0 || width <= 0 || length > 20 || width > 20)
            {
                Console.WriteLine("There is an error with the input");
            }

            else
            {
                Length = length;
                Width = width;
            }
        }

        public float Perimeter() {
            float result = (2 * Length) + (2*Width);
            return result;
        }

        public float Area() {
            float result = (Length * Width);
            return result;
        }
    }
}
