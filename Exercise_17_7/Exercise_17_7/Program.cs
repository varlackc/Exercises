using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_7
{
    class Program
    {
        //declare integer arrays
        static int[] numbers = new int[7];

        //list of available letters
        static char[][] allLetters = {
            new char[] {'A','B','C'},
            new char[] { 'D','E','F'},
            new char[] { 'G','H','I'},
            new char[] { 'J','K','L'},
            new char[] { 'M','N','O'},
            new char[] { 'P','Q','R','S'},
            new char[] { 'T','U','V'},
            new char[] { 'W','X','Y', 'Z'}
        };

        //array of letters corresponding to the 7 letter number
        static char[][] letters = new char[7][]; 

        static void Main(string[] args)
        {
            ExplainToUser();
            GetInput();
            GetLettersVariations();
            Console.ReadLine();
        }

        static void ExplainToUser()
        {
            Console.WriteLine("\t-------------------------------------------------");
            Console.WriteLine("\t| Exercise 17.7                                 |");
            Console.WriteLine("\t| Description: Shows the different letter       |");
            Console.WriteLine("\t| convinations given a seven digit number       |");
            Console.WriteLine("\t-------------------------------------------------");
            Console.WriteLine();
        }

        public static void GetInput()
        {
            //get the number from the user. This will correspond with indexes in letters array
            Console.Write("Please enter 7 digit number (do not use number 0 and 1): ");
            string number = Console.ReadLine();

            for (int i = 0; i < 7; i++)
            {
                int index = Convert.ToInt32(number.Substring(i, 1)) - 2; //our dial starts from number 2 (0 and 1 are not used)
                letters[i] = allLetters[index];
            }

        }

        public static void GetLettersVariations()
        {

            string word = "";

            for (int i1 = 0; i1 < letters[0].Length; i1++)
            {
                for (int i2 = 0; i2 < letters[1].Length; i2++)
                {
                    for (int i3 = 0; i3 < letters[2].Length; i3++)
                    {
                        for (int i4 = 0; i4 < letters[3].Length; i4++)
                        {
                            for (int i5 = 0; i5 < letters[4].Length; i5++)
                            {
                                for (int i6 = 0; i6 < letters[5].Length; i6++)
                                {
                                    for (int i7 = 0; i7 < letters[6].Length; i7++)
                                    {
                                        word = letters[0][i1].ToString();
                                        word += letters[1][i2].ToString();
                                        word += letters[2][i3].ToString();
                                        word += letters[3][i4].ToString();
                                        word += letters[4][i5].ToString();
                                        word += letters[5][i6].ToString();
                                        word += letters[6][i7].ToString();

                                        using (System.IO.StreamWriter file =
                                          new System.IO.StreamWriter("WriteLines.txt", true))
                                        {
                                            file.WriteLine(word);
                                        }
                                        word = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}