using System;
using System.Drawing;
using System.Windows.Forms;

namespace Work
{
    public partial class Form3 : Form
    {
        public int caseCnt = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (caseCnt)    // 모든 값 입력 체크
            {
                case 0:
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력해주세요.");
                        return;
                    }
                    break;
                case 1:
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == ""
                        || textBox2_1.Text == "" || textBox2_4.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력해주세요.");
                        return;
                    }
                    break;
                case 2:
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == ""
                        || textBox2_1.Text == "" || textBox2_4.Text == "" || textBox3_1.Text=="" || textBox3_4.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력해주세요.");
                        return;
                    }
                    break;
                case 3:
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == ""
                        || textBox2_1.Text == "" || textBox2_4.Text == "" || textBox3_1.Text == "" || textBox3_4.Text == ""
                        || textBox4_1.Text == "" || textBox4_4.Text == "")
                    {
                        MessageBox.Show("모든 값을 입력해주세요.");
                        return;
                    }
                    break;
            }

            // 고정 값 설정
            if (textBox6.Text == "")        // 기타 1
                textBox6.Text = "0";
            if (textBox2_6.Text == "")      // 기타 2
                textBox2_6.Text = "0";
            if (textBox3_6.Text == "")      // 기타 3
                textBox3_6.Text = "0";
            if (textBox4_6.Text == "")      // 기타 4
                textBox4_6.Text = "0";
            if (textBox8.Text == "")        // 조정
                textBox8.Text = "0";

            double totalNumber = 0; 
            switch (caseCnt)    // 총 갯수 정하기
            {
                case 0:
                    totalNumber = Double.Parse(textBox4.Text);
                    break;
                case 1:
                    totalNumber = Double.Parse(textBox4.Text) + Double.Parse(textBox2_4.Text);
                    break;
                case 2:
                    totalNumber = Double.Parse(textBox4.Text) + Double.Parse(textBox2_4.Text) + Double.Parse(textBox3_4.Text);
                    break;
                case 3:
                    totalNumber = Double.Parse(textBox4.Text) + Double.Parse(textBox2_4.Text) + Double.Parse(textBox3_4.Text) + Double.Parse(textBox4_4.Text);
                    break;
            }
            double oneOfETC = (Double.Parse(textBox2.Text) + Double.Parse(textBox3.Text) + Double.Parse(textBox5.Text)) / totalNumber;

            // 전체 매입가
            double krw = Math.Round(Double.Parse(textBox1.Text) * Double.Parse(textBox7.Text), 1);
            result8.Text = Comma.appendComma(Comma.Round(krw));

            // 전체 원가
            double result1Text = Comma.Round(krw) + (oneOfETC* Double.Parse(textBox4.Text)) + Double.Parse(textBox6.Text);
            result1.Text = Comma.appendComma((int)Math.Round(result1Text, 1));

            // 개당 매입가
            double result7Text = krw / Double.Parse(textBox4.Text);
            result7.Text = Comma.appendComma(Comma.Round(result7Text));

            // 개당 원가
            double result4Text = result1Text / Double.Parse(textBox4.Text);
            result4.Text = Comma.appendComma(Comma.Round(result4Text));

            // 조정가
            double result3Text = Double.Parse(textBox8.Text) / 100 * result4Text + result4Text;
            result3.Text = Comma.appendComma(Comma.Round(result3Text));

            // 매입가 대비
            //double result2Text = result1Text / krw * 100; // 매입가 대비 원가
            double result2Text = result3Text / result7Text * 100;   // 매입가 대비 조정가
            result2.Text = Comma.appendComma(Comma.Round(result2Text)) + "% / " + Comma.appendComma(Math.Round(result2Text / 100, 2)) + "배";

            if (caseCnt >= 1)
            {
                // 전체 매입가
                double krw2 = Math.Round(Double.Parse(textBox2_1.Text) * Double.Parse(textBox7.Text), 1);
                result2_8.Text = Comma.appendComma(Comma.Round(krw2));

                // 전체 원가
                double result2_1Text = Comma.Round(krw2) + (oneOfETC * Double.Parse(textBox2_4.Text)) + Double.Parse(textBox2_6.Text);
                result2_1.Text = Comma.appendComma((int)Math.Round(result2_1Text, 1));

                // 개당 매입가
                double result2_7Text = krw2 / Double.Parse(textBox2_4.Text);
                result2_7.Text = Comma.appendComma(Comma.Round(result2_7Text));

                // 개당 원가
                double result2_4Text = result2_1Text / Double.Parse(textBox2_4.Text);
                result2_4.Text = Comma.appendComma(Comma.Round(result2_4Text));

                // 조정가
                double result2_3Text = Double.Parse(textBox8.Text) / 100 * result2_4Text + result2_4Text;
                result2_3.Text = Comma.appendComma(Comma.Round(result2_3Text));

                // 매입가 대비
                //double result2Text = result1Text / krw * 100; // 매입가 대비 원가
                double result2_2Text = result2_3Text / result2_7Text * 100;   // 매입가 대비 조정가
                result2_2.Text = Comma.appendComma(Comma.Round(result2_2Text)) + "% / " + Comma.appendComma(Math.Round(result2_2Text / 100, 2)) + "배";
            }

            if (caseCnt >= 2)
            {
                // 전체 매입가
                double krw3 = Math.Round(Double.Parse(textBox3_1.Text) * Double.Parse(textBox7.Text), 1);
                result3_8.Text = Comma.appendComma(Comma.Round(krw3));

                // 전체 원가
                double result3_1Text = Comma.Round(krw3) + (oneOfETC * Double.Parse(textBox3_4.Text)) + Double.Parse(textBox3_6.Text);
                result3_1.Text = Comma.appendComma((int)Math.Round(result3_1Text, 1));

                // 개당 매입가
                double result3_7Text = krw3 / Double.Parse(textBox3_4.Text);
                result3_7.Text = Comma.appendComma(Comma.Round(result3_7Text));

                // 개당 원가
                double result3_4Text = result3_1Text / Double.Parse(textBox3_4.Text);
                result3_4.Text = Comma.appendComma(Comma.Round(result3_4Text));

                // 조정가
                double result3_3Text = Double.Parse(textBox8.Text) / 100 * result3_4Text + result3_4Text;
                result3_3.Text = Comma.appendComma(Comma.Round(result3_3Text));

                // 매입가 대비
                //double result2Text = result1Text / krw * 100; // 매입가 대비 원가
                double result3_2Text = result3_3Text / result3_7Text * 100;   // 매입가 대비 조정가
                result3_2.Text = Comma.appendComma(Comma.Round(result3_2Text)) + "% / " + Comma.appendComma(Math.Round(result3_2Text / 100, 2)) + "배";
            }

            if (caseCnt >= 3)
            {
                // 전체 매입가
                double krw4 = Math.Round(Double.Parse(textBox4_1.Text) * Double.Parse(textBox7.Text), 1);
                result4_8.Text = Comma.appendComma(Comma.Round(krw4));

                // 전체 원가
                double result4_1Text = Comma.Round(krw4) + (oneOfETC * Double.Parse(textBox4_4.Text)) + Double.Parse(textBox4_6.Text);
                result4_1.Text = Comma.appendComma((int)Math.Round(result4_1Text, 1));

                // 개당 매입가
                double result4_7Text = krw4 / Double.Parse(textBox4_4.Text);
                result4_7.Text = Comma.appendComma(Comma.Round(result4_7Text));

                // 개당 원가
                double result4_4Text = result4_1Text / Double.Parse(textBox4_4.Text);
                result4_4.Text = Comma.appendComma(Comma.Round(result4_4Text));

                // 조정가
                double result4_3Text = Double.Parse(textBox8.Text) / 100 * result4_4Text + result4_4Text;
                result4_3.Text = Comma.appendComma(Comma.Round(result4_3Text));

                // 매입가 대비
                //double result2Text = result1Text / krw * 100; // 매입가 대비 원가
                double result4_2Text = result4_3Text / result4_7Text * 100;   // 매입가 대비 조정가
                result4_2.Text = Comma.appendComma(Comma.Round(result4_2Text)) + "% / " + Comma.appendComma(Math.Round(result4_2Text / 100, 2)) + "배";
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
            textBox8.Text = "";
            //textBox7.Text = "";   // 환율
            textBox2_1.Text = "";
            textBox2_4.Text = "";
            textBox2_6.Text = "";
            textBox3_1.Text = "";
            textBox3_4.Text = "";
            textBox3_6.Text = "";
            textBox4_1.Text = "";
            textBox4_4.Text = "";
            textBox4_6.Text = "";

            result1.Text = "";
            result2.Text = "";
            result3.Text = "";
            result4.Text = "";
            result7.Text = "";
            result8.Text = "";
            result2_1.Text = "";
            result2_2.Text = "";
            result2_3.Text = "";
            result2_4.Text = "";
            result2_7.Text = "";
            result2_8.Text = "";
            result3_1.Text = "";
            result3_2.Text = "";
            result3_3.Text = "";
            result3_4.Text = "";
            result3_7.Text = "";
            result3_8.Text = "";
            result4_1.Text = "";
            result4_2.Text = "";
            result4_3.Text = "";
            result4_4.Text = "";
            result4_7.Text = "";
            result4_8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)  // 케이스 추가 버튼
        {
            if (caseCnt == 3) return;
            caseCnt++;
            this.Size = new System.Drawing.Size(800, 293 + 70 * caseCnt);
            Group1(1);
            switch (caseCnt)
            {
                case 1:
                    label17.Visible = true;
                    label20.Visible = true;
                    textBox2_1.Visible = true;
                    textBox2_4.Visible = true;
                    textBox2_6.Visible = true;
                    result2_1.Visible = true;
                    result2_4.Visible = true;
                    result2_3.Visible = true;
                    result2_2.Visible = true;
                    result2_8.Visible = true;
                    result2_7.Visible = true;
                    break;
                case 2:
                    label18.Visible = true;
                    label21.Visible = true;
                    textBox3_1.Visible = true;
                    textBox3_4.Visible = true;
                    textBox3_6.Visible = true;
                    result3_1.Visible = true;
                    result3_4.Visible = true;
                    result3_3.Visible = true;
                    result3_2.Visible = true;
                    result3_8.Visible = true;
                    result3_7.Visible = true;
                    Group2(1);
                    break;
                case 3:
                    label19.Visible = true;
                    label22.Visible = true;
                    textBox4_1.Visible = true;
                    textBox4_4.Visible = true;
                    textBox4_6.Visible = true;
                    result4_1.Visible = true;
                    result4_4.Visible = true;
                    result4_3.Visible = true;
                    result4_2.Visible = true;
                    result4_8.Visible = true;
                    result4_7.Visible = true;
                    Group2(1);
                    Group3(1);
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)  // 케이스 삭제 버튼
        {
            if (caseCnt == 0) return;
            caseCnt--;
            this.Size = new System.Drawing.Size(800, 503 - 70 * (3 - caseCnt));
            Group1(-1);
            switch (caseCnt)
            {
                case 0:
                    label17.Visible = false;
                    label20.Visible = false;
                    textBox2_1.Visible = false;
                    textBox2_4.Visible = false;
                    textBox2_6.Visible = false;
                    result2_1.Visible = false;
                    result2_4.Visible = false;
                    result2_3.Visible = false;
                    result2_2.Visible = false;
                    result2_8.Visible = false;
                    result2_7.Visible = false;
                    break;
                case 1:
                    label18.Visible = false;
                    label21.Visible = false;
                    textBox3_1.Visible = false;
                    textBox3_4.Visible = false;
                    textBox3_6.Visible = false;
                    result3_1.Visible = false;
                    result3_4.Visible = false;
                    result3_3.Visible = false;
                    result3_2.Visible = false;
                    result3_8.Visible = false;
                    result3_7.Visible = false;
                    Group2(-1);
                    break;
                case 2:
                    label19.Visible = false;
                    label22.Visible = false;
                    textBox4_1.Visible = false;
                    textBox4_4.Visible = false;
                    textBox4_6.Visible = false;
                    result4_1.Visible = false;
                    result4_4.Visible = false;
                    result4_3.Visible = false;
                    result4_2.Visible = false;
                    result4_8.Visible = false;
                    result4_7.Visible = false;
                    Group2(-1);
                    Group3(-1);
                    break;
            }
        }

        void Group1(int x)
        {
            button3.Location = new Point(button3.Location.X, button3.Location.Y + (35 * x));
            button4.Location = new Point(button4.Location.X, button4.Location.Y + (35 * x));
            label11.Location = new Point(label11.Location.X, label11.Location.Y + (35 * x));
            label16.Location = new Point(label16.Location.X, label16.Location.Y + (35 * x));
            textBox7.Location = new Point(textBox7.Location.X, textBox7.Location.Y + (35 * x));
            textBox8.Location = new Point(textBox8.Location.X, textBox8.Location.Y + (35 * x));
            button1.Location = new Point(button1.Location.X, button1.Location.Y + (35 * x));
            button2.Location = new Point(button2.Location.X, button2.Location.Y + (35 * x));

            label5.Location = new Point(label5.Location.X, label5.Location.Y + (35 * x));
            label13.Location = new Point(label13.Location.X, label13.Location.Y + (35 * x));
            label9.Location = new Point(label9.Location.X, label9.Location.Y + (35 * x));
            label7.Location = new Point(label7.Location.X, label7.Location.Y + (35 * x));
            label10.Location = new Point(label10.Location.X, label10.Location.Y + (35 * x));
            label15.Location = new Point(label15.Location.X, label15.Location.Y + (35 * x));
            label14.Location = new Point(label14.Location.X, label14.Location.Y + (35 * x));
            result1.Location = new Point(result1.Location.X, result1.Location.Y + (35 * x));
            result4.Location = new Point(result4.Location.X, result4.Location.Y + (35 * x));
            result3.Location = new Point(result3.Location.X, result3.Location.Y + (35 * x));
            result8.Location = new Point(result8.Location.X, result8.Location.Y + (35 * x));
            result7.Location = new Point(result7.Location.X, result7.Location.Y + (35 * x));
            result2.Location = new Point(result2.Location.X, result2.Location.Y + (35 * x));
        }

        void Group2(int x)
        {
            label20.Location = new Point(label20.Location.X, label20.Location.Y + (35 * x));
            result2_1.Location = new Point(result2_1.Location.X, result2_1.Location.Y + (35 * x));
            result2_3.Location = new Point(result2_3.Location.X, result2_3.Location.Y + (35 * x));
            result2_2.Location = new Point(result2_2.Location.X, result2_2.Location.Y + (35 * x));
            result2_7.Location = new Point(result2_7.Location.X, result2_7.Location.Y + (35 * x));
            result2_8.Location = new Point(result2_8.Location.X, result2_8.Location.Y + (35 * x));
            result2_4.Location = new Point(result2_4.Location.X, result2_4.Location.Y + (35 * x));
        }

        void Group3(int x)
        {
            label21.Location = new Point(label21.Location.X, label21.Location.Y + (35 * x));
            result3_1.Location = new Point(result3_1.Location.X, result3_1.Location.Y + (35 * x));
            result3_3.Location = new Point(result3_3.Location.X, result3_3.Location.Y + (35 * x));
            result3_2.Location = new Point(result3_2.Location.X, result3_2.Location.Y + (35 * x));
            result3_7.Location = new Point(result3_7.Location.X, result3_7.Location.Y + (35 * x));
            result3_8.Location = new Point(result3_8.Location.X, result3_8.Location.Y + (35 * x));
            result3_4.Location = new Point(result3_4.Location.X, result3_4.Location.Y + (35 * x));
        }
    }
}
