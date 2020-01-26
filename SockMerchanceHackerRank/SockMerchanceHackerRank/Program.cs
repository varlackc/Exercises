using System;
using System.Collections.Generic;

namespace SockMerchanceHackerRank
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int result = 0;
            //Create an array 
            List<int> colors = new List<int>();//Colors available
            List<int> arList = new List<int>(ar);
            List<int> matches = new List<int>();

            colors = GetColors(arList); // Get color list

            //create a copy of the array as a list
            DisplayIntList(arList);
            //arList.RemoveAt(1);
            DisplayIntList(colors);
            matches = GetMatches(colors, arList);
            DisplayIntList(matches);
            result = CalculatePairs(matches);

            return result;
        }

        static List<int> GetColors(List<int> ar) {
            var arSize = ar.Count;
            int currentColor = 0;
            List<int> colors = new List<int>();
            for (int i = 0; i < arSize; i++)
            {
                currentColor = ar[i];
                if (!(colors.Contains(currentColor)))
                {
                    colors.Add(currentColor);
                }
            }
            return colors;
        }

        static List<int> GetMatches(List<int> color, List<int> ar){
            List<int> matches = new List<int>();
            int colorSize = color.Count;
            int count = 0;

            for (int i = 0; i < colorSize; i++)
            {
                for (int j = 0; j < ar.Count; j++)
                {
                    if (color[i] == ar[j])
                    {
                        count++;
                    }
                }
                matches.Add(count);
                count = 0;
            }
            return matches;
        }

        static void DisplayArray(int[] ar)
        {
            int arSize = 0;
            arSize = ar.Length;
            Console.WriteLine();//new Space
            for (int i = 0; i < arSize; i++)
            {
                Console.Write(" " + ar[i]);
            }
            Console.WriteLine();
        }

        static void DisplayIntList(List<int> ar)
        {
            int arSize = 0;
            arSize = ar.Count;
            Console.WriteLine();//new Space
            for (int i = 0; i < arSize; i++)
            {
                Console.Write(" " + ar[i]);
            }
            Console.WriteLine();
        }

        static int CalculatePairs(List<int> matches)
        {
            int results = 0;
            int divisorByTwo = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                divisorByTwo = matches[i] / 2;
                results += divisorByTwo;
            }
            return results;
        }

        static void Main(string[] args)
        {
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            sockMerchant(9, ar);
        }
    }
}
