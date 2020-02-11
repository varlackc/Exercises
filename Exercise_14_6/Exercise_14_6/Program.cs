/*
  (Temperature Conversions) Write a temperature conversion program that 
  converts from Fahrenheit to Celsius. The Fahrenheit temperature should be 
  entered from the keyboard (via a TextBox). A Label should be used to display 
  the converted temperature. Use the following formula for the conversion:

  Celsius = ( 5 / 9 ) × ( Fahrenheit − 32 )
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_14_6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureCalculator());
        }
    }
}
