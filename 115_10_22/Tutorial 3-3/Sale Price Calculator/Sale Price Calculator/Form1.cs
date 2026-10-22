using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice; //原價
            decimal discountPercent; //折扣百分比
            decimal price; //售價

            originalPrice = decimal.Parse(originalPriceTextBox.Text); 
            discountPercent = decimal.Parse(discountPercentageTextBox.Text); 
            price = originalPrice * (1 - discountPercent / 100);

            salePriceLabel.Text = price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
