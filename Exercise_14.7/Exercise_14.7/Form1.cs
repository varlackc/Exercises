using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_14._7
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        int width = 5;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            //Improve line quality
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(System.Drawing.Color.Black, width);
            //make the ends of the lines round
           pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        
        // Red button
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton p = (RadioButton)sender;
            pen.Color = System.Drawing.Color.Red;

        }

        //Blue Button
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton p = (RadioButton)sender;
            pen.Color = System.Drawing.Color.Blue;
        }

        //Green Button

        private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

            RadioButton p = (RadioButton)sender;
            pen.Color = System.Drawing.Color.Green;
        }

        //Black Button
        private void RadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

            RadioButton p = (RadioButton)sender;
            pen.Color = System.Drawing.Color.Black;
        }

        // If button is presed then start moving
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x,y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        // Small Size
        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton p = (RadioButton)sender;
            pen.Width = 2;
        }

        // Medium Size
        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton p = (RadioButton)sender;
            pen.Width = 5;
        }

        // Large Size
        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton p = (RadioButton)sender;
            pen.Width = 7;
        }
    }
}
