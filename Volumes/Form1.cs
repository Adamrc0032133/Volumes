using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declare variables 
            double Radius, Volume;

            //Read Valcues from text box 
            try
            {
                Radius = double.Parse(textBox1.Text);
            }
            catch

            {
                MessageBox.Show("Type a number in the Radius Box!");
                Radius = 0.0;


                //Calculate volume 
                Volume = 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;

                // Display Volume 
                Text = "Volume = " + Volume + "m^3";

            }

        }



    }
}
