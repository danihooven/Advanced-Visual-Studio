using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Traveled
{
    public partial class Form1 : Form
    {
        // Constant fields
        const double FIVE_HOUR_VALUE = 5;
        const double EIGHT_HOUR_VALUE = 8;
        const double TWELVE_HOUR_VALUE = 12;

        // Field variables to hold the distance traveled,
        // initialized with 0.
        private double totalDistanceTraveled5;    // To hold the distance traveled in 5 miles
        private double totalDistanceTraveled8;    // To hold the distance traveled in 8 miles
        private double totalDistanceTraveled12;    // To hold the distance traveled in 12 miles

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double speed;   // To hold the speed in mph

                // Get the speed in mph and it assign it to
                // the speed variable
                speed = double.Parse(speedTextBox.Text);

                // Calculate the distance traveled in 5 hours
                // and display
                totalDistanceTraveled5 = speed * FIVE_HOUR_VALUE;
                distance5Label.Text = totalDistanceTraveled5.ToString();

                // Calculate the distance traveled in 8 hours
                // and display total
                totalDistanceTraveled8 = speed * EIGHT_HOUR_VALUE;
                distance8Label.Text = totalDistanceTraveled8.ToString();

                // Calculate the distance traveled in 12 hours
                // and display total
                totalDistanceTraveled12 = speed * TWELVE_HOUR_VALUE;
                distance12Label.Text = totalDistanceTraveled12.ToString();
            }
           catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls
            speedTextBox.Text = "";
            distance5Label.Text = "";
            distance8Label.Text = "";
            distance12Label.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
