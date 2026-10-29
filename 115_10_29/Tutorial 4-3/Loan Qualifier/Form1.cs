using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // Minimum salary requirement
            const int MIN_YEARS = 2; // Minimum years of employment requirement 

            decimal salary; // To hold the user's salary
            int yearsOnJob; // To hold the user's years of employment

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                if (yearsOnJob >= MIN_SALARY)
                {
                    if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但是年資不符合貸款資格";
                    }
                }
                else
                {
                    decisionLabel.Text = "薪資不符合貸款資格";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numeric values for salary and years of employment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
