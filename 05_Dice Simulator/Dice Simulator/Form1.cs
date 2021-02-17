using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            // Variable to indicate dice value
            int dieValue_1;
            int dieValue_2;

            // Create a Random object.
            Random rand_1 = new Random();
            Random rand_2 = new Random();

            // Get a random integer in the range of 0 through 5.
            // 0 = die picture 1, 1 = die picture 2, etc.
            dieValue_1 = rand_1.Next(5);
            dieValue_2 = rand_2.Next(5);

            // Display the value rolled for die_1.
            switch (dieValue_1)
            {
                // Display dieValue_1
                case 0:
                    diePictureBox1_1.Visible = true;
                    diePictureBox2_1.Visible = false;
                    diePictureBox3_1.Visible = false;
                    diePictureBox4_1.Visible = false;
                    diePictureBox5_1.Visible = false;
                    diePictureBox6_1.Visible = false;
                    break;
                case 1:
                    diePictureBox1_1.Visible = false;
                    diePictureBox2_1.Visible = true;
                    diePictureBox3_1.Visible = false;
                    diePictureBox4_1.Visible = false;
                    diePictureBox5_1.Visible = false;
                    diePictureBox6_1.Visible = false;
                    break;
                case 2:
                    diePictureBox1_1.Visible = false;
                    diePictureBox2_1.Visible = false;
                    diePictureBox3_1.Visible = true;
                    diePictureBox4_1.Visible = false;
                    diePictureBox5_1.Visible = false;
                    diePictureBox6_1.Visible = false;
                    break;
                case 3:
                    diePictureBox1_1.Visible = false;
                    diePictureBox2_1.Visible = false;
                    diePictureBox3_1.Visible = false;
                    diePictureBox4_1.Visible = true;
                    diePictureBox5_1.Visible = false;
                    diePictureBox6_1.Visible = false;
                    break;
                case 4:
                    diePictureBox1_1.Visible = false;
                    diePictureBox2_1.Visible = false;
                    diePictureBox3_1.Visible = false;
                    diePictureBox4_1.Visible = false;
                    diePictureBox5_1.Visible = true;
                    diePictureBox6_1.Visible = false;
                    break;
                case 5:
                    diePictureBox1_1.Visible = false;
                    diePictureBox2_1.Visible = false;
                    diePictureBox3_1.Visible = false;
                    diePictureBox4_1.Visible = false;
                    diePictureBox5_1.Visible = false;
                    diePictureBox6_1.Visible = true;
                    break;
            }

            // Display the value rolled for die_2.
            switch (dieValue_2)
            {
                // Display dieValue_1
                case 0:
                    diePictureBox1_2.Visible = true;
                    diePictureBox2_2.Visible = false;
                    diePictureBox3_2.Visible = false;
                    diePictureBox4_2.Visible = false;
                    diePictureBox5_2.Visible = false;
                    diePictureBox6_2.Visible = false;
                    break;
                case 1:
                    diePictureBox1_2.Visible = false;
                    diePictureBox2_2.Visible = true;
                    diePictureBox3_2.Visible = false;
                    diePictureBox4_2.Visible = false;
                    diePictureBox5_2.Visible = false;
                    diePictureBox6_2.Visible = false;
                    break;
                case 2:
                    diePictureBox1_2.Visible = false;
                    diePictureBox2_2.Visible = false;
                    diePictureBox3_2.Visible = true;
                    diePictureBox4_2.Visible = false;
                    diePictureBox5_2.Visible = false;
                    diePictureBox6_2.Visible = false;
                    break;
                case 3:
                    diePictureBox1_2.Visible = false;
                    diePictureBox2_2.Visible = false;
                    diePictureBox3_2.Visible = false;
                    diePictureBox4_2.Visible = true;
                    diePictureBox5_2.Visible = false;
                    diePictureBox6_2.Visible = false;
                    break;
                case 4:
                    diePictureBox1_2.Visible = false;
                    diePictureBox2_2.Visible = false;
                    diePictureBox3_2.Visible = false;
                    diePictureBox4_2.Visible = false;
                    diePictureBox5_2.Visible = true;
                    diePictureBox6_2.Visible = false;
                    break;
                case 5:
                    diePictureBox1_2.Visible = false;
                    diePictureBox2_2.Visible = false;
                    diePictureBox3_2.Visible = false;
                    diePictureBox4_2.Visible = false;
                    diePictureBox5_2.Visible = false;
                    diePictureBox6_2.Visible = true;
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
