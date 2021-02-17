using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        // Create a Car object.
        Car myCar = new Car();

        public Form1()
        {
            InitializeComponent();
        }

        // The GetCarData method accepts a Car object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetCarData(Car car)
        {

            // Get the car's year
            car.Year = yearTextBox.Text;

            // Get the car's make
            car.Make = makeTextBox.Text;

            // Set car speed.
            car.Speed = 0;

        }

        private void createCarButton_Click(object sender, EventArgs e)
        {

            // Get the car data.
            GetCarData(myCar);

            // Display the phone data
            yearLabel.Text = myCar.Year;
            makeLabel.Text = myCar.Make;
            speedLabel.Text = myCar.Speed.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            myCar.Brake(5);
            speedLabel.Text = myCar.Speed.ToString();

        }

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            myCar.Accelerate(5);
            speedLabel.Text = myCar.Speed.ToString();
        }
    }
}
