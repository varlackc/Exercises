using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_15_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboStates.Items.Remove(comboStates.SelectedItem);
        }
    }
}
