using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {

        // Constant field to convert percentage to decimal
        private const decimal CONVERT_PERCENT = 0.01m;
        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is sucessful, the method return true. Otherwise it reutrns
        // false.
        private bool InputIsValid(ref decimal cost, ref decimal percentage)
        {
            // Flag variable to indicate whether the input is good
            bool inputGood = false;

            // Try to convert both inputs to decimal.
            if (decimal.TryParse(wholesaleCostTextbox.Text, out cost))
            {
                if (decimal.TryParse(markupPercentageTextBox.Text, out percentage))
                {
                    // Both inputs are good.
                    inputGood = true;
                }
                else
                {
                    // Display an error message for the cost.
                    MessageBox.Show("Wholesale Cost is invalid.");
                }
            }
            else
            {
                // Display an error message for the percentage.
                MessageBox.Show("Markup Percentage is invalid.");
            }

            // Return the result.
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for wholesale cost, markup percentage, and retail price.
            decimal cost = 0m, percentage = 0m, price = 0m;

            if (InputIsValid(ref cost, ref percentage))
            {

                // Calculate the retail price.
                price = cost + (cost * (percentage * CONVERT_PERCENT));

                // Display the price.
                priceLabel.Text = price.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }

}
