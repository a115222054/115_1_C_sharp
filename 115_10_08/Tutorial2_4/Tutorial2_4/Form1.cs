using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FinlandpictureBox_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "芬蘭";
        }

        private void FrancepictureBox_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "法國";
        }

        private void GermanypictureBox_Click(object sender, EventArgs e)
        {
            countrylabel.Text = "德國";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
