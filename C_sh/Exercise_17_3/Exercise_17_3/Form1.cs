using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercise_17_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define the file path and use a verbatim literal to make the code more readable
            string filePath = @"C:\Users\Owner\source\repos\Exercise_17_3\Exercise_17_3\grades.txt";
            if (File.Exists(filePath))
            {
                StreamReader stream = new StreamReader(filePath);
                textBox1.AppendText(stream.ReadToEnd());
            }
            else
            {
                MessageBox.Show("The is an error trying to Read The Document");
            }
        }
    }
}