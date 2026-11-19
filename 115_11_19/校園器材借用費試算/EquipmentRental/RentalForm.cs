using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            discountLabel.Text = "—";

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days < 1 || days > 7)
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
                else
                {
                    int dailyRate;
                    if (days <= 2)
                    {
                        dailyRate = 80;
                    }
                    else if (days <= 5)
                    {
                        dailyRate = 70;
                    }
                    else
                    {
                        dailyRate = 60;
                    }

                    int discount;
                    string feedback;
                    if (clubCheckBox.Checked)
                    {
                        if (days >= 3)
                        {
                            discount = 30;
                            feedback = "折抵30元";
                        }
                        else
                        {
                            discount = 0;
                            feedback = "無優惠";
                        }
                    }
                    else
                    {
                        discount = 0;
                        feedback = "無優惠";
                    }

                    int total = dailyRate * days - discount;
                    dailyRateLabel.Text = dailyRate.ToString() + " 元";
                    discountLabel.Text = discount.ToString() + " 元";
                    totalLabel.Text = total.ToString() + " 元";
                    feedbackLabel.Text = feedback;
                }
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clubCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 清除_Click(object sender, EventArgs e)
        {
            daysTextBox.Text = "";
            feedbackLabel.Text = "";
            clubCheckBox.Checked = false;
            dailyRateLabel.Text = "—";
            discountLabel.Text = "—";
            totalLabel.Text = "—";
        }
    }
}
