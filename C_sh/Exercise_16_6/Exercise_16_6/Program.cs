using System;

namespace Exercise_16_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string word;

            // Explain the program to the user
            ExplainToUser();

            // get the input from the user
            word = Console.ReadLine();

            // display the results
            DisplayResults(word);
            
            Console.ReadLine();
        }


        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t ===============================================================");
            Console.WriteLine("\t| Evalurate three word combinations in a five letter word \t|");
            Console.WriteLine("\t ===============================================================");
            Console.WriteLine();

            Console.WriteLine("Please enter a five letter word in order to get all of the possible three letter combinations");
            Console.WriteLine();
        }

        //Evaluate a five letter word to form all the possible three letter words
        public static void DisplayResults(string word)
        {
            // loop to get the first character
            for (int i = 0; i < 5; i++)
            {
                // loop to get the second character
                for (int j = i; j < 5; j++)
                {
                    //loop to get the third character
                    for (int k = j; k < 5; k++)
                    {
                        //evaluate to see if the character combination should be displayed. 
                        if (i != j && i != k && j != k)
                        {
                            Console.Write(word.Substring(i, 1) + word.Substring(j, 1) + word.Substring(k, 1) + " ");
                            Console.Write(word.Substring(i, 1) + word.Substring(k, 1) + word.Substring(j, 1) + " ");
                            Console.Write(word.Substring(j, 1) + word.Substring(i, 1) + word.Substring(k, 1) + " ");
                            Console.Write(word.Substring(k, 1) + word.Substring(i, 1) + word.Substring(j, 1) + " ");
                            Console.Write(word.Substring(j, 1) + word.Substring(k, 1) + word.Substring(i, 1) + " ");
                            Console.Write(word.Substring(k, 1) + word.Substring(j, 1) + word.Substring(i, 1) + " ");
                            Console.WriteLine();
                        }
                    }

                }
            }
        }
    }
}
