using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Work
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("모든 값을 입력해주세요.");
            }
            else
            {
                if (textBox6.Text == "")
                    textBox6.Text = "0";

                double krw = Math.Round(Double.Parse(textBox1.Text) * Double.Parse(textBox7.Text),1);

                // --- 전체 ---
                result8.Text = Comma.appendComma(Comma.Round(krw));

                double result1Text = Comma.Round(krw) + Double.Parse(textBox2.Text) + Double.Parse(textBox3.Text) + Double.Parse(textBox5.Text) + Double.Parse(textBox6.Text);
                result1.Text = Comma.appendComma((int)Math.Round(result1Text,1));

                double result2Text = result1Text / krw * 100;
                result2.Text = Comma.appendComma(Math.Round(result2Text, 1)) + "%";

                double result3Text = result2Text / 100;
                result3.Text = Comma.appendComma(Math.Round(result3Text, 2)) + "배";

                // --- 개당 ---
                double result7Text = krw / Double.Parse(textBox4.Text); // 매입가
                result7.Text = Comma.appendComma(Comma.Round(result7Text));

                double result4Text = result1Text / Double.Parse(textBox4.Text);
                result4.Text = Comma.appendComma(Comma.Round(result4Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            result1.Text = "";
            result2.Text = "";
            result3.Text = "";
            result4.Text = "";
            result7.Text = "";
            result8.Text = "";
        }
    }
}
