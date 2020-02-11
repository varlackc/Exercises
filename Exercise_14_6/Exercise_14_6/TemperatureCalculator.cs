using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_14_6
{
    public partial class TemperatureCalculator : Form
    {
        public TemperatureCalculator()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InputFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //declare a variable to ensure that only digits are inserted
            char ch = e.KeyChar;

            //ensure that more than one dot character is not inserted
            if (ch == 46 && InputFahrenheit.Text.IndexOf('.') != -1) {
                // ignore value in case that it is a second dot
                e.Handled = true;
            }

            // In case of the wrong character being inserted
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                //ignore value in case that it is not a digit
                e.Handled = true;
            }
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            //declare variables
            float inputValue = 0;
            float result = 0;
            
            //try to calculate the values and display on the result label
            try
            {
                //get the input from the textbox and convert to a float
                inputValue = float.Parse(InputFahrenheit.Text);

                // calculate the result using the formula C = (F - 32) * 5/9
                result = ((inputValue - 32) * 5)/9;

                //take the result, convert to a string and display 
                ResultLabel.Text = result.ToString();
            }
            catch
            {
                ResultLabel.Text = "Error";
            }

        }
    }
}
