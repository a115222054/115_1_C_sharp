using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, System.EventArgs e)
        {
            string stringl, string2;    

            string string1 = txtString1.Text;
            string string2 = txtString2.Text;
            if (string.Compare(string1, string2) == 0)
            {
                MessageBox.Show("兩個字串相同。", "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(string.Compare(string1, string2) <0)  
            {
                MessageBox.Show("兩個字串不同。", "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                MessageBox.Show("請輸入兩個字串進行比較。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = string.Equals(string1, string2, System.StringComparison.Ordinal)
                ? "兩個字串相同。"
                : "兩個字串不同。";

            MessageBox.Show(message, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
