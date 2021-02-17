using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The WordCount method accepts a string agrument
        // and returns the number of words it contains.
        private int WordCounter(string str)
        {
            int wordCount = 0;      // Word counter

            // Trim the string.
            str = str.Trim();

            // Count the number of words in str.
            foreach (char ch in str)
            {
                if (char.IsWhiteSpace(ch))
                {
                    wordCount++;
                }
            }

            // Return the total word count.
            return wordCount + 1;
                        
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            // Get the string from the TextBox
            string str = stringTextBox.Text;

            // Validate the string
            if (str.Length >= 1)
            {
                // Get the total word count
                int totalWordCount = WordCounter(str);

                // Display the total word count
                MessageBox.Show("The total number of words is " + totalWordCount.ToString());
            }
        }
    }
}
