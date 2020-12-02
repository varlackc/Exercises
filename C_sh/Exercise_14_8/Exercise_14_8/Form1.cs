using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_14_8
{
    public partial class Form1 : Form
    {
        //Initialize variables
        int guessedNumber = 0;
        static int computerNumber = 0;
        static string msg;
        static int difference = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the form
            initialize();
        }

        private void StartNewBT_Click(object sender, EventArgs e)
        {
            //initialize the form
            initialize();
        }

        private void EnterGuessBT_Click(object sender, EventArgs e)
        {
            // get the number from the user
            guessedNumber = Convert.ToInt32(textBox1.Text);

            // assign the colors of the boxes depending on the conditions
            if (computerNumber - guessedNumber < difference)
            {
                textBox1.BackColor = Color.Blue;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            // display message to the user based on the size of the number
            if (guessedNumber > computerNumber)
            {
                msg = "The Number Is Too High";
                textBox1.Focus();
                
            }
            else if (guessedNumber < computerNumber)
            {
                msg = "The Number Is Too Low";
                textBox1.Focus();
            }
            else
            {
                msg = "Correct";
                textBox1.BackColor = Color.Green;
                EnterGuessBT.Enabled = false;
            }

            //display the result
            Message.Text = msg;

            // calculate the difference
            difference = computerNumber - guessedNumber;

        }

        // Initialize the game
        private void initialize()
        {
            // generate a random number
            var rand = new Random();

            computerNumber = rand.Next(1, 1001);

            //Enable buttons
            EnterGuessBT.Enabled = true;
            StartNewBT.Enabled = true;

            // clear text box
            textBox1.Clear();
            textBox1.BackColor = Color.White;

            //clear the message
            Message.Text = " ";
        }
    }
}
