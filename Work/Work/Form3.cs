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

                if (textBox8.Text == "")
                    textBox8.Text = "0";

                // 전체 매입가
                double krw = Math.Round(Double.Parse(textBox1.Text) * Double.Parse(textBox7.Text),1);
                result8.Text = Comma.appendComma(Comma.Round(krw));

                // 전체 원가
                double result1Text = Comma.Round(krw) + Double.Parse(textBox2.Text) + Double.Parse(textBox3.Text) + Double.Parse(textBox5.Text) + Double.Parse(textBox6.Text);
                result1.Text = Comma.appendComma((int)Math.Round(result1Text,1));

                // 개당 매입가
                double result7Text = krw / Double.Parse(textBox4.Text);
                result7.Text = Comma.appendComma(Comma.Round(result7Text));

                // 개당 원가
                double result4Text = result1Text / Double.Parse(textBox4.Text);
                result4.Text = Comma.appendComma(Comma.Round(result4Text));

                // 조정가
                double result3Text = Double.Parse(textBox8.Text)/100 * result4Text + result4Text;
                result3.Text = Comma.appendComma(Comma.Round(result3Text));

                // 매입가 대비
                //double result2Text = result1Text / krw * 100; // 매입가 대비 원가
                double result2Text = result3Text / result7Text * 100;   // 매입가 대비 조정가
                result2.Text = Comma.appendComma(Comma.Round(result2Text)) + "% / " + Comma.appendComma(Math.Round(result2Text / 100, 2)) + "배";

            }
            //result1.Location = new Point(0, 0);
            //this.Size = new System.Drawing.Size(100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            //textBox7.Text = "";   // 환율
            textBox8.Text = "";

            result1.Text = "";
            result2.Text = "";
            result3.Text = "";
            result4.Text = "";
            result7.Text = "";
            result8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)  // 케이스 추가 버튼
        {

        }

        private void button4_Click(object sender, EventArgs e)  // 케이스 삭제 버튼
        {

        }
    }
}
