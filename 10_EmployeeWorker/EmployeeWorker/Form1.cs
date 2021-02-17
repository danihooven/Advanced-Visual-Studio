using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string name = empNameTextBox.Text;
            int id = Convert.ToInt32(empIdTextBox.Text);
            int shift = Convert.ToInt32(shiftNumTextBox.Text);
            decimal pay = Convert.ToDecimal(hourlyPayTextBox.Text);

            ProductionWorker worker = new ProductionWorker(name, id, shift, pay);
            outputTextBox.Text = worker.ToString();
        }
    }
}
