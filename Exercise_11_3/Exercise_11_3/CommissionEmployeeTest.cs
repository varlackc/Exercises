/*
Carlos Maxwell Varlack

Description:

11.3 (Composition vs. Inheritance) 
Many apps written with inheritance could be written with composition instead, and vice versa. 
Rewrite class BasePlusCommissionEmployee (Fig. 11.11) of the CommissionEmployee–BasePlusCommissionEmployee 
hierarchy to use composition rather than inheritance.
 */

using System;

using static Exercise_11_3.CommissionEmployee;

namespace Exercise_11_3
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string firstName = "Carlos";
            string lastName = "Varlack";
            string ssn = "555-55-5555";
            int sales = 6000;
            decimal rate = (decimal) 0.4;
            decimal salary = 3000;

            //(string first, string last, string socialSec, decimal sales, 
            //decimal rate, decimal salary)

            //create object
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee(firstName, lastName, 
                ssn, sales, rate, salary);

            //Explain the program to the user
            ExplainToUser();

            //Display the results to the user
            DisplayResults(employee);

            // Wait until the user desides to close the program
            Console.ReadLine();
        }

        //Explain the program to the user
        public static void ExplainToUser()
        {
            Console.WriteLine();
            Console.WriteLine("\t ===============================================");
            Console.WriteLine("\t| Commission Calculation Application \t\t|");
            Console.WriteLine("\t ===============================================");
            Console.WriteLine();
        }

        //Show the parameters to the user
        public static void DisplayResults(BasePlusCommissionEmployee employee)
        {
            Console.WriteLine("\t First Name: " + employee.Commission1.FirstName);
            Console.WriteLine("\t Last Name: " + employee.Commission1.LastName);
            Console.WriteLine("\t Social Security: " + employee.Commission1.SocialSecurityNumber);
            Console.WriteLine("\t Gross Sales: " + employee.Commission1.GrossSales);
            Console.WriteLine("\t Commission Rate: " + employee.Commission1.CommissionRate);
            Console.WriteLine("\t Base Salary: " + employee.BaseSalary);
            Console.WriteLine("\t Earnings: " + employee.Earnings());
            Console.WriteLine();
        }

    }
}