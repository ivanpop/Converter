using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertor
{
    public partial class Form1 : Form
    {
        double a, b;
        bool result1, result2;

        public void nullify()
        {
            kgBox.Text = "0";
            lbsBox.Text = "0";
            cmBox.Text = "0";
            inchesBox.Text = "0";
            feetBox.Text = "0";
            feetInchBox.Text = "0";
            kmhBox.Text = "0";
            mphBox.Text = "0";
        }

        public void error_msg()
        {
            resultLabel.Text = "Wrong input!";
            nullify();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result1 = Double.TryParse(kgBox.Text, out a);
            if (!result1) error_msg();            

            if (a != 0)
            {
                a *= 2.204622622;
                a = System.Math.Round(a, 1);
                resultLabel.Text = kgBox.Text + " kg is: " + System.Convert.ToString(a) + " pounds.";
                nullify();
            }

            result1 = Double.TryParse(lbsBox.Text, out a);
            if (!result1) error_msg(); 

            if (a != 0)
            {
                a *= 0.45359237;
                a = System.Math.Round(a, 1);
                resultLabel.Text = lbsBox.Text + " lbs is: " + System.Convert.ToString(a) + " kg.";
                nullify();
            }

            result1 = Double.TryParse(cmBox.Text, out a);
            if (!result1) error_msg(); 

            if (a != 0)
            {
                a *= 0.3937008;
                a = System.Math.Round(a, 1);
                resultLabel.Text = cmBox.Text + " cm is: " + System.Convert.ToString(a) + " inches.";
                nullify();
            }

            result1 = Double.TryParse(inchesBox.Text, out a);
            if (!result1) error_msg(); 

            if (a != 0)
            {
                a *= 2.54;
                a = System.Math.Round(a, 1);
                resultLabel.Text = inchesBox.Text + " inches is: " + System.Convert.ToString(a) + " cm.";
                nullify();
            }

            result1 = Double.TryParse(feetBox.Text, out a);
            result2 = Double.TryParse(feetInchBox.Text, out b);
            if (!result1 || !result2) error_msg();

            if (a != 0)
            {
                a *= 30.48;
                b *= 2.54;
                a += b;
                a = System.Math.Round(a, 1);
                resultLabel.Text = feetBox.Text + "' " + feetInchBox.Text + "'' is " + System.Convert.ToString(a) + " cm.";
                nullify();
            }

            result1 = Double.TryParse(kmhBox.Text, out a);
            if (!result1) error_msg();

            if (a != 0)
            {
                a *= 0.621371192;
                a = System.Math.Round(a, 0);
                resultLabel.Text = kmhBox.Text + " kmh is: " + System.Convert.ToString(a) + " mph.";
                nullify();
            }

            result1 = Double.TryParse(mphBox.Text, out a);
            if (!result1) error_msg();

            if (a != 0)
            {
                a *= 1.609344;
                a = System.Math.Round(a, 0);
                resultLabel.Text = mphBox.Text + " mph is: " + System.Convert.ToString(a) + " kmh.";
                nullify();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0 \nBuild date: 7.12.2013 20:12\nInitial Release", "About");
        }
    }
}
