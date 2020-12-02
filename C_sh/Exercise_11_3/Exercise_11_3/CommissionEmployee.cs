/*
Carlos Maxwell Varlack

Exercise 11.3
 */

using System;

namespace Exercise_11_3
{
    //commission employee class
    public class CommissionEmployee : object
    {
        private string FirstN;
        private string LastN;
        private string SocialSecurityN;
        private decimal GrossS;
        private decimal CommissionR;

        //Constructor
        public CommissionEmployee(string firstName, string lastName, string socialSecurity,
            decimal sales, decimal rate)
        {
            FirstN = firstName;
            LastN = lastName;
            SocialSecurityN = socialSecurity;
            GrossS = sales;
            CommissionR = rate;
        }

        // read only properties
        public string FirstName { get { return FirstN; } }
        public string LastName { get { return LastN; } }
        public string SocialSecurityNumber { get { return SocialSecurityN; } }

        public decimal GrossSales { get { return GrossS; } set {
                if (value >= 0)
                {
                    GrossS = value;
                }
                else {
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >=0");
                }
            }
        }

        public decimal CommissionRate { get { return CommissionR; } set {
                if (value > 0 && value < 1)
                {
                    CommissionR = value;
                }

                else {
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
                }

            }
        }

        public decimal Earnings() {
            return CommissionR * GrossS;
        }

        public class BasePlusCommissionEmployee {
            private decimal baseSalary;
            private CommissionEmployee commission1;

            public BasePlusCommissionEmployee(string first, string last, string socialSec, decimal sales, 
                decimal rate, decimal salary)
            {
                commission1 = new CommissionEmployee(first, last, socialSec, sales, rate);
                BaseSalary = salary;
            }

            public decimal BaseSalary { get { return baseSalary; } set {

                    if (value >= 0)
                    {
                        baseSalary = value;
                    }
                    else {
                        throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >=0");
                    }
         
                 }
            }
            
            //read only
            public CommissionEmployee Commission1 { get { return commission1; } }

            public decimal Earnings() {
                return BaseSalary + Commission1.Earnings();
            }

        }
    }
}