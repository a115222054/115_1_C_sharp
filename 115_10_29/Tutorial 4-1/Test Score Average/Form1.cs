using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double NUMBER_OF_TESTS = 95.0; // Number of tests

            double test1, test2, test3, average;

            try
            { 
               test1 = double.Parse(test1TextBox.Text);
               test2 = double.Parse(test2TextBox.Text);
               test3 = double.Parse(test3TextBox.Text);
                
                average = (test1 + test2 + test3) / 3.0;


                averageLabel.Text = average.ToString("F1");

                if (average >= NUMBER_OF_TESTS)
                {
                    MessageBox.Show("平均分數及格");
                }
                else
                {
                    MessageBox.Show("平均分數不及格");
                }   
            }
            catch (FormatException)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }

            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
