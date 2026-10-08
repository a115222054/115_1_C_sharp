using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showbackbutton1_Click(object sender, EventArgs e)
        {
            cardpackpictureBox1.Visible = true;
            cardfacepictureBox2.Visible = false;
        }

        private void showfacebutton2_Click(object sender, EventArgs e)
        {
            cardfacepictureBox2.Visible = true;
            cardpackpictureBox1.Visible = false;
        }
    }
}
