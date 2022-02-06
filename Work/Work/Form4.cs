using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Work
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("모든 값을 입력해주세요.");
            }
            else
            {
                double fee = Double.Parse(textBox1.Text) * (Double.Parse(textBox2.Text) / 100);
                double result2Text = (Double.Parse(textBox4.Text) - Double.Parse(textBox1.Text) - fee - Double.Parse(textBox3.Text));
                result2.Text = Comma.appendComma(Math.Round(result2Text,1));

                result3.Text = Comma.appendComma(Math.Round((result2Text / Double.Parse(textBox1.Text)) * 100,1)) + "%";

                if(textBox5.Text == "")
                    result1.Text = Comma.appendComma(Math.Round(result2Text, 1));
                else
                    result1.Text = Comma.appendComma(Math.Round(result2Text * (Double.Parse(textBox5.Text)),1));
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            result1.Text = "";
            result2.Text = "";
        }
    }
}
