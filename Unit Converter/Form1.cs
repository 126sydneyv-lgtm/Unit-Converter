using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        int choice;
        double value;

        public Form1()
        {
            InitializeComponent();
        }
        //calculates inches to cm
        double InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }
        //calculates feet to cm
        double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }
        //calculates yards to metres
        double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres;
        }
        //calculates miles to km
        double MilesToKm(double miles)
        {
            double km = miles * 1.6;
            return km;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt16(choiceTextbox.Text);
            value = Convert.ToDouble(valueTextbox.Text);
            double result = 0;
            string unit;
            string unit2;
            //displays result depending on choice
            if (choice == 1)
            {
                result = InchesToCm(value);
                unit = "inches";
                unit2 = "cm";
            }
            else if (choice == 2)
            {
                result = FeetToCm(value);
                unit = "feet";
                unit2 = "cm";
            }
            else if (choice == 3)
            {
                result = YardsToMetres(value);
                unit = "yards";
                unit2 = "metres";
            }
            else
            {
                result = MilesToKm(value);
                unit = "miles";
                unit2 = "km";
            }

            //display result
            resultLabel.Text = "" + value + " " + unit + " = " + result.ToString("F2") + " " + unit2;
        }
    }
}
