using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Local variables
            int speed;          // The vehicles speed in MPH
            int hours;      // The hours traveled
            int count = 1;      // Loop counter
            int distance;   // The distance traveled
            
            // Get the vechicles speed in MPH
            if (int.TryParse(speedTextBox.Text, out speed))
            {
                // Get the hours traveled
                if (int.TryParse(hoursTextBox.Text, out hours))
                {
                    // The following loop calculates the distance traveled.
                    while (count <= hours)
                    {
                        // Distance = rate x time
                        distance = (speed * count);

                        // Display the distance traveled.
                        outputListBox.Items.Add("After hour " + count + " the distance traveled is " + distance);

                        // Add one to the loop counter.
                        count = count + 1;
                    }
                }
                else
                {
                    // Invalid number of hours was entered.
                    MessageBox.Show("Invalid value for hours.");
                }
            }
            else
            {
                // Invalid starting balance was entered.
                MessageBox.Show("Invalid value for starting balance.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
