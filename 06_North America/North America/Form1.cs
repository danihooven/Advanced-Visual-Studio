using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // and arguemnt.
        private void GetFileName(out string selectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        // The GetCountries method accepts a filename as an
        // argument. It opensthe specified file and ispalys
        // its contents in the countiesLIstBox control.
        private void GetCountries(string filename)
        {
            try
            {
                // Declare a variable to hold a country name.
                string countryName;

                // Decalre a StringReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText(filename);

                // Clear anything currently in the ListBox.
                countriesListBox.Items.Clear();

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    // Get a country name.
                    countryName = inputFile.ReadLine();

                    // Add the country anme to the ListBox.
                    countriesListBox.Items.Add(countryName);

                    // Close the file.
                    inputFile.Close();
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string filename;        // To hold the filename

            // Get the filename from the user.
            GetFileName(out filename);

            // Get the countries from the file.
            GetCountries(filename);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
