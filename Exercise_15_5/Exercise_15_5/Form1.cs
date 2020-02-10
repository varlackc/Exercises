using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exercise_15_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // if there is text in the text box then add to the list
            if (this.textBox1.Text != "")
            {
                listBox1.Items.Add(this.textBox1.Text);
            }

            //create an array list to facilitate the sorting process
            ArrayList stringList = new ArrayList();

            // add all of the items to the string list
            foreach (var item in listBox1.Items)
            {
                stringList.Add(item);
            }

            //sort the string list
            stringList.Sort();

            //clear the items in the listBox1
            listBox1.Items.Clear();

            //add sorted elements to the list box
            foreach (var item in stringList)
            {
                listBox1.Items.Add(item);
            }



        }
    }
}
