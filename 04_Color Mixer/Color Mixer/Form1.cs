using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            // Orange color combinations
            if (redRadioButton1.Checked && yellowRadioButton2.Checked || yellowRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else
            {
                // Purple color combinations
                if(redRadioButton1.Checked && blueRadioButton2.Checked || blueRadioButton1.Checked && redRadioButton2.Checked)
                {
                    this.BackColor = Color.Purple;
                }
                else
                {
                    // Green color combinations
                    if (yellowRadioButton1.Checked && blueRadioButton2.Checked || blueRadioButton1.Checked && yellowRadioButton2.Checked)
                    {
                        this.BackColor = Color.Green;
                    }
                    else
                    {
                        // Red color combinations
                        if (redRadioButton1.Checked && redRadioButton2.Checked)
                        {
                            this.BackColor = Color.Red;
                        }
                        else
                        {
                            // Blue color combinations
                            if (blueRadioButton1.Checked && blueRadioButton2.Checked)
                            {
                                this.BackColor = Color.Blue;
                            }
                            else
                            {
                                // Yellow color combinations
                                if (yellowRadioButton1.Checked && yellowRadioButton2.Checked)
                                {
                                    this.BackColor = Color.Yellow;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }
    }
}
