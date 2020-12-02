using System;

namespace Exercise_20_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int val1 = 5;
            int val2 = 2;
            int val3 = 5;
            string val4 = "one";
            string val5 = "One";
            string val6 = "one";
            string val7 = "two";
            string val8 = "5";
            bool result = false;

            //Explain the program to the user
            ExplainToUser();

            //Test values for Equality
            result = IsEqualTo(val1, val2);
            Console.WriteLine("Is " + val1 +" = "+ val2+" ? : " + result);

            result = IsEqualTo(val1, val3);
            Console.WriteLine("Is " + val1 + " = " + val3 + " ? : " + result);

            result = IsEqualTo(val4, val6);
            Console.WriteLine("Is " + val4 + " = " + val6 + " ? : " + result);

            result = IsEqualTo(val4, val5);
            Console.WriteLine("Is " + val4 + " = " + val5 + " ? : " + result);

            result = IsEqualTo(val2, val7);
            Console.WriteLine("Is " + val2 + " = " + val7 + " ? : " + result);

            result = IsEqualTo(val1, val8);
            Console.WriteLine("Is " + val1 + " (int) = " + val8 + " (string) ? : " + result);


            Console.ReadLine();
        }

        static bool IsEqualTo<S,T>(S parameterA, T parameterB)
        {
            //determine if the values are the same
            var result = parameterA.Equals(parameterB);
            //return the result;
            return result;
        }

        static void ExplainToUser()
        {
            Console.WriteLine("\t ----------------------------------------------");
            Console.WriteLine("\t| This Program Uses Generics To Compare Values |");
            Console.WriteLine("\t ----------------------------------------------");
            Console.WriteLine();
        }

    }
}
