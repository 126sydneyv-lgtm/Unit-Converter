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
        int conversionChoice;
        int value;
       
        public Form1()
        {
            InitializeComponent();
        }

        private double InchesToCm(double conversionValue)
        {
            if (conversionChoice == 1)
            {
                value = Convert.ToInt32(valueTextbox);
                return conversionValue = value * 2.54;
               
            }
        }

        private void FeetToCm()
        {

        }

        private void YardsToMetres()
        {

        }

        private void MilesToKm()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            conversionChoice = Convert.ToInt32(choiceTextbox);
        }
    }
}
