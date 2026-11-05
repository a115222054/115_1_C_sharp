using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        private object litersTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kmpl; //儲存行駛公里數
            double liters; //儲存使用汽油公升數
            double km; //儲存每公升汽油行駛公里數

            if (!double.TryParse(mpgLabel.Text, out kmpl))
            {
                if (!double.TryParse(gallonsTextBox.Text, out liters))
                {   
                    if (kmpl >= 0 && liters >0)
                 
                    kmpl = kmpl / liters; //計算每公升汽油行駛公里數
                    milesPromptLabel.Text = kmpl.ToString("F2") + "公里/公升";  
                }   
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
