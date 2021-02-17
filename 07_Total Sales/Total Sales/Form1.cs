using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Total method accepts an int array argument
        // and returns the Total of the values in the array.
        private double Total(double[] dArray)
        {
            // Declare and initialize an accumulator variable.
            double total = 0;

            // Step through the array, adding each element to
            // the accumulator.
            for (int index = 0; index < dArray.Length; index++)
            {
                total += dArray[index];
            }

            // Return the total.
            return total;
        }

        private void getSalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an array to hold items read from the file.
                const int SIZE = 7;             // Number of sales
                double[] sales = new double[SIZE];    // Array of sales
                double totalSales;              // To hold the total sales

                // Counter variable to use int he loop
                int index = 0;

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                // Read the file's contents into the array.
                while (index < sales.Length && !inputFile.EndOfStream)
                {
                    sales[index] = Double.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file.
                inputFile.Close();

                // Display the array elemetns in the list box.
                foreach (double values in sales)
                {
                    outputListBox.Items.Add(values);
                }

                // Get the total sales.
                totalSales = Total(sales);

                // Display the value.
                totalSalesLabel.Text = totalSales.ToString();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
