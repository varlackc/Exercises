using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 
 14.8 (Guess the Number Game) Write a program that plays “guess the number” 
 as follows: Your program chooses the number to be guessed by selecting an
 int at random in the range 1–1000. The program then displays the following text 
 in a label:

Program code. Line 1: I have a number between 1 and 1000, dash, dash,
can you guess my number? Line 2: Please enter your first guess period.
A TextBox should be used to input the guess. As each guess is input, 
the background color should change to red or blue. 

Red indicates that the user is getting “warmer,” blue that the user is getting
“colder.” A Label should display either “Too High” or “Too Low,” 
to help the user zero in on the correct answer. 

When the user guesses the correct answer, display “Correct!” in a message box, 
change the Form’s background color to green and disable the TextBox. 

Recall that a TextBox (like other controls) can be disabled by setting the control’s
Enabled property to false. Provide a Button that allows the user to play the game again.
When the Button is clicked, generate a new random number, 
change the background to the default color and enable the TextBox.
 
*/

namespace Exercise_14_8
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
            Application.Run(new Form1());
        }
    }
}
