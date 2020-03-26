using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // clear the box on button click

            // Variables
            int f = 2, i = 0, m;
            string v = "";

            // try - catch for double
            try
            {
                f = Convert.ToInt32(textBoxTableNum.Text);
            }
            catch 
            {
                labelError.Text = "Numbers only."; // error text
            }

            while(i < 10) // while i is less than 10
            {
                i++; // i = i + 1
                m = f * i; 

                v = $"f: {f,3}    i: {i,3}    m: {m,3}"; // string to write out
                listBoxResult.Items.Add(v); // string added to listBox
            }
        }
    }
}
