/*
 4.12 (Date Class) Create a class called Date 
 that includes three pieces of information as 
 auto-implemented properties—a month (type int),
 a day (type int) and a year (type int). 
 
 Your class should have a constructor that initializes 
 the three automatic properties and assumes 
 that the values provided are correct. 
 
 Provide a method DisplayDate that displays the month, 
 day and year separated by forward slashes (/). 
 
 Write a test app named DateTest that demonstrates 
 class Date’s capabilities.
 */

using System;

namespace Exercise_4_12
{
    public class Date
    {
        //Declare auto increment properties
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        //Constructor to initialize the properties
        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        // Display the date 
        public void DisplayDate() {
            Console.WriteLine("\t "+Month+" / "+Day+" / "+Year+" ");
        }

    }
}