﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {

        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an arugment. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price.
            decimal price;

            // Get the phone's brand.
            phone.Brand = brandTextBox.Text;

            // Get the phone's model.
            phone.Model = modelTextBox.Text;

            // Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            // Get the phone data.
            GetPhoneData(myPhone);

            // Add the CellPhone object to the List.
            phoneList.Add(myPhone);

            // Add an entry to the list box.
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            // Clear the TextBox controls.
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // Reset the focus.
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = phoneListBox.SelectedIndex;

            // Display the selected item's price.
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
