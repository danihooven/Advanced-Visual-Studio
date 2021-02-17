using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;

        private void createObjectsButton_Click(object sender, EventArgs e)
        {
            // creating array of objects
            Textbook[] tb = new Textbook[3];

            //initializing objects by constructor
            tb[0] = new Textbook("Java How to Program, Early Objects", new string[]{"Harvey Deitel", "Paul Deitel"}, 1248, 44.99, 13, "Computer Programming Languages");
            tb[1] = new Textbook("Starting Out With Visual Basic", new string[] { "Kip R. Irvine", "Tony Gaddis" }, 936, 166.75, 13, "Computer Programming Languages");
            tb[2] = new Textbook("Starting Out With Visual C#", new string[] { "Tony Gaddis" }, 800, 153.32, 13, "Computer Programming Languages");

            // loop to display books using BookPrint method
            // loop to calculate total
            for (int index = 0; index <= tb.Length-1; index++)
            {
                MessageBox.Show(tb[index].BookPrint());
                total += tb[index].Price;
            }

            MessageBox.Show("Total: " +total.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }
    }
}
