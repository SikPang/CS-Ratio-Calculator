using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Work
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || (textBox3.Text == "" && textBox4.Text == ""))
            {
                MessageBox.Show("모든 값을 입력해주세요.");
            }
            else
            {
                double one = Double.Parse(textBox2.Text) / Double.Parse(textBox1.Text);
                if (textBox3.Text != "") // 개수 입력 시
                {
                    textBox4.Text = Comma.appendComma(Math.Round(one * Double.Parse(textBox3.Text),1));
                }
                else                     // 값 입력 시
                {
                    textBox3.Text = Comma.appendComma(Math.Round(Double.Parse(textBox4.Text)/one,1));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
