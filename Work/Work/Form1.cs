using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "오늘도 화이팅!";
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();
        }
    }
}
