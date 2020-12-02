/*
 Carlos Maxwell Varlack

12.10 (Shape Hierarchy) Implement the Shape hierarchy of Fig. 11.3. Omit the Triangle and Tetrahedron classes. 
Each TwoDimensionalShape should contain read-only abstract property Area to calculate the area of the two-dimensional shape.
Each ThreeDimensionalShape should have read-only abstract properties Area and Volume to calculate the surface area and volume,
respectively, of the three-dimensional shape. 

Create an app that uses an array of Shape references to objects of each concrete class in the hierarchy. 
Display a text description of the object to which each array element refers. 
Also, in the loop that processes all the shapes in the array, 
determine whether each shape is a TwoDimensionalShape or a ThreeDimensionalShape.
If a shape is a TwoDimensionalShape, display its area. If a shape is a ThreeDimensionalShape, 
display its area and volume.
 */

using System;
using System.Collections.Generic;

namespace Exercise12_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a shape array
            Shape[] shape = new Shape[4];

            // populate the array with different geometric shapes
            shape[0] = new Square(7);
            shape[1] = new Circle(7);
            shape[2] = new Cube(7);
            shape[3] = new Sphere(7);

            // Explain the program to the user
            ExplainToUser();

            // display the results
            DisplayResults(shape);


            Console.ReadLine();
        }


        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t ===============================");
            Console.WriteLine("\t| Property of Geometric Shapes \t|");
            Console.WriteLine("\t ===============================");
            Console.WriteLine();
        }

        //Show the parameters to the user
        public static void DisplayResults(IEnumerable<Shape> shape)
        {//the IEnumerable allows for more than one shape to be inserted into the method
            foreach (Shape element in shape)
            {
                Console.WriteLine("\n" + "\t"+element);
                Console.WriteLine(string.Format("\tThe area is " + element.Area));
                if (element is ThreeDimensionalShape)
                {
                    ThreeDimensionalShape threeDshape = (ThreeDimensionalShape)element;
                    Console.WriteLine(string.Format("\tThe volume is " + threeDshape.Volume + "\n"));
                }
            }

        }

    }
}
