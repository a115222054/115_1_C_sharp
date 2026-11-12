using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const  decimal RATE = 0.005m;
            decimal Balance;
            int Months; 

            int count = 1;
            if (decimal.TryParse(startingBalTextBox.Text, out Balance))
            {
                if (int.TryParse(monthsTextBox.Text, out Months))
                {
                    int month = 1; 
                    while (count <= Months)
                    {
                        Balance = Balance * (1 + RATE);
                        detailListBox.Items.Add($"第 {count}個月的本利和: {Balance:C2}");
                        count = count + 1;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量");
                }
            }
            else
            {
                monthsTextBox.Text =("請輸入有效的起始餘額");
            }
            endingBalanceLabel.Text = Balance.ToString("C2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
