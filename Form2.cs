using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form2 : Form
    {
        Form4 f2 = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("กลับสู่หน้าแรก");
            this.Hide();
            Form1 MForm = new Form1();
            MForm.ShowDialog();
            this.Close();
        }

        double a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,num1,num2,num3,num4,num5,num6,num7,num8,num9,num10,num11,num12,num13,num14,num15,num16,num17,num18,num19,num20,num21,num22,num23,num24,num25,alltotal;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ee = new Form1();
            ee.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 ggg = new Form5();
            ggg.ShowDialog();
        }

        private void groupBox26_Enter(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            {
                f2.Show();
                f2.textBox2.Text = textBox26.Text;
                //f2.bill.Text = textBox27.Text + "\r\n" + textBox28.Text + "\r\n" + textBox29.Text + "\r\n" + textBox30.Text + "\r\n" + textBox31.Text + "\r\n" + textBox32.Text + "\r\n" + textBox33.Text + "\r\n" + textBox34.Text + "\r\n" + textBox35.Text + "\r\n" + textBox36.Text + "\r\n" + textBox37.Text + "\r\n" + textBox38.Text + "\r\n" + textBox39.Text + "\r\n" + textBox40.Text + "\r\n" + textBox41.Text + "\r\n" + textBox42.Text + "\r\n" + textBox43.Text + "\r\n" + textBox44.Text + "\r\n" + textBox45.Text + "\r\n" + textBox46.Text + "\r\n" + textBox47.Text + "\r\n" + textBox48.Text + "\r\n" + textBox49.Text + "\r\n" + textBox50.Text + "\r\n" + textBox51.Text;
                
                if (textBox27.Text != "")
                {
                    if(textBox1.Text != "0")
                    {
                        f2.bill.Text += textBox27.Text;
                        f2.bill.Text += textBox1.Text + "ชิ้น" + $"  {num1}B" + "\r\n";
                    }
                }
                if (textBox28.Text != "")
                {
                    if(textBox2.Text != "0")
                    {
                        f2.bill.Text += textBox28.Text;
                        f2.bill.Text += textBox2.Text + "ชิ้น" + $"  {num2}B" + "\r\n";
                    }
                }
                if (textBox29.Text != "")
                {
                    if(textBox3.Text != "0")
                    {
                        f2.bill.Text += textBox29.Text;
                        f2.bill.Text += textBox3.Text + "ชิ้น" + $"  {num3}B" + "\r\n";
                    }
                }
                if (textBox30.Text != "")
                {
                    if (textBox4.Text != "0")
                    {
                        f2.bill.Text += textBox30.Text;
                        f2.bill.Text += textBox4.Text + "ชิ้น" + $"  {num4}B" + "\r\n";
                    }
                }
                if (textBox31.Text != "")
                {
                    if (textBox5.Text != "0")
                    {
                        f2.bill.Text += textBox31.Text;
                        f2.bill.Text += textBox5.Text + "ชิ้น" + $"  {num5}B" + "\r\n";
                    }
                }
                if (textBox32.Text != "")
                {
                    if (textBox6.Text != "0")
                    {
                        f2.bill.Text += textBox32.Text;
                        f2.bill.Text += textBox6.Text + "ชิ้น" + $"  {num6}B" + "\r\n";
                    }
                }
                if (textBox33.Text != "")
                {
                    if (textBox7.Text != "0")
                    {
                        f2.bill.Text += textBox33.Text;
                        f2.bill.Text += textBox7.Text + "ชิ้น" + $"  {num7}B" + "\r\n";
                    }
                }
                if (textBox34.Text != "")
                {
                    if (textBox8.Text != "0")
                    {
                        f2.bill.Text += textBox34.Text;
                        f2.bill.Text += textBox8.Text + "ชิ้น" + $"  {num8}B" + "\r\n";
                    }
                }
                if (textBox35.Text != "")
                {
                    if (textBox9.Text != "0")
                    {
                        f2.bill.Text += textBox35.Text;
                        f2.bill.Text += textBox9.Text + "ชิ้น" + $"  {num9}B" + "\r\n";
                    }
                }
                if (textBox36.Text != "")
                {
                    if (textBox10.Text != "0")
                    {
                        f2.bill.Text += textBox36.Text;
                        f2.bill.Text += textBox10.Text + "ชิ้น" + $"  {num10}B" + "\r\n";
                    }
                }
                if (textBox37.Text != "")
                {
                    if (textBox11.Text != "0")
                    {
                        f2.bill.Text += textBox37.Text;
                        f2.bill.Text += textBox11.Text + "ชิ้น" + $"  {num11}B" + "\r\n";
                    }
                }
                if (textBox38.Text != "")
                {
                    if (textBox12.Text != "0")
                    {
                        f2.bill.Text += textBox38.Text;
                        f2.bill.Text += textBox12.Text + "ชิ้น" + $"  {num12}B" + "\r\n";
                    }
                }
                if (textBox39.Text != "")
                {
                    if (textBox13.Text != "0")
                    {
                        f2.bill.Text += textBox39.Text;
                        f2.bill.Text += textBox13.Text + "ชิ้น" + $"  {num13}B" + "\r\n";
                    }
                }
                if (textBox40.Text != "")
                {
                    if (textBox14.Text != "0")
                    {
                        f2.bill.Text += textBox40.Text;
                        f2.bill.Text += textBox14.Text + "ชิ้น" + $"  {num14}B" + "\r\n";
                    }
                }
                if (textBox41.Text != "")
                {
                    if (textBox15.Text != "0")
                    {
                        f2.bill.Text += textBox41.Text;
                        f2.bill.Text += textBox15.Text + "ชิ้น" + $"  {num15}B" + "\r\n";
                    }
                }
                if (textBox42.Text != "")
                {
                    if (textBox16.Text != "0")
                    {
                        f2.bill.Text += textBox42.Text;
                        f2.bill.Text += textBox16.Text + "ชิ้น" + $"  {num16}B" + "\r\n";
                    }
                }
                if (textBox43.Text != "")
                {
                    if (textBox17.Text != "0")
                    {
                        f2.bill.Text += textBox43.Text;
                        f2.bill.Text += textBox17.Text + "ชิ้น" + $"  {num17}B" + "\r\n";
                    }
                }
                if (textBox44.Text != "")
                {
                    if (textBox18.Text != "0")
                    {
                        f2.bill.Text += textBox44.Text;
                        f2.bill.Text += textBox18.Text + "ชิ้น" + $"  {num18}B" + "\r\n";
                    }
                }
                if (textBox45.Text != "")
                {
                    if (textBox19.Text != "0")
                    {
                        f2.bill.Text += textBox45.Text;
                        f2.bill.Text += textBox19.Text + "ชิ้น" + $"  {num19}B" + "\r\n";
                    }
                }
                if (textBox46.Text != "")
                {
                    if (textBox20.Text != "0")
                    {
                        f2.bill.Text += textBox46.Text;
                        f2.bill.Text += textBox20.Text + "ชิ้น" + $"  {num20}B" + "\r\n";
                    }
                }
                if (textBox47.Text != "")
                {
                    if (textBox21.Text != "0")
                    {
                        f2.bill.Text += textBox47.Text;
                        f2.bill.Text += textBox21.Text + "ชิ้น" + $"  {num21}B" + "\r\n";
                    }
                }
                if (textBox48.Text != "")
                {
                    if (textBox22.Text != "0")
                    {
                        f2.bill.Text += textBox48.Text;
                        f2.bill.Text += textBox22.Text + "ชิ้น" + $"  {num22}B" + "\r\n";
                    }
                }
                if (textBox49.Text != "")
                {
                    if (textBox23.Text != "0")
                    {
                        f2.bill.Text += textBox49.Text;
                        f2.bill.Text += textBox23.Text + "ชิ้น" + $"  {num23}B" + "\r\n";
                    }
                }
                if (textBox50.Text != "")
                {
                    if (textBox24.Text != "0")
                    {
                        f2.bill.Text += textBox50.Text;
                        f2.bill.Text += textBox24.Text + "ชิ้น" + $"  {num24}B" + "\r\n";
                    }
                }
                if (textBox51.Text != "")
                {
                    if (textBox25.Text != "0")
                    {
                        f2.bill.Text += textBox51.Text;
                        f2.bill.Text += textBox25.Text + "ชิ้น" + $"  {num25}B" + "\r\n";
                    }
                }
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown25.Show();
            if (checkBox25.Checked)
            {
                numericUpDown25.Show();
                numericUpDown25.Enabled = true;
                textBox51.Text = "เตาแก๊ส";
            }
            else
            {
                textBox51.Text = " ";
                numericUpDown25.Hide();
                numericUpDown25.Enabled = false;
                numericUpDown25.Value = 0;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown24.Show();
            if (checkBox24.Checked)
            {
                numericUpDown24.Show();
                numericUpDown24.Enabled = true;
                textBox50.Text = "ทำอาหาร";
            }
            else
            {
                textBox50.Text = " ";
                numericUpDown24.Hide();
                numericUpDown24.Enabled = false;
                numericUpDown24.Value = 0;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown23.Show();
            if (checkBox23.Checked)
            {
                numericUpDown23.Enabled = true;
                textBox49.Text = "ทอดไข่";
            }
            else
            {
                textBox49.Text = " ";
                numericUpDown23.Hide();
                numericUpDown23.Enabled = false;
                numericUpDown23.Value = 0;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown22.Show();
            if (checkBox22.Checked)
            {
                numericUpDown22.Enabled = true;
                textBox48.Text = "ห้องครัว";
            }
            else
            {
                textBox48.Text = " ";
                numericUpDown22.Hide();
                numericUpDown22.Enabled = false;
                numericUpDown22.Value = 0;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown21.Show();
            if (checkBox21.Checked)
            {
                numericUpDown21.Enabled = true;
                textBox47.Text = "ทำความสะอาดบ้าน";
            }
            else
            {
                textBox47.Text = " ";
                numericUpDown21.Hide();
                numericUpDown21.Enabled = false;
                numericUpDown21.Value = 0;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown20.Show();
            if (checkBox20.Checked)
            {
                numericUpDown20.Enabled = true;
                textBox46.Text = "เจ้าหญิงม่วง";
            }
            else
            {
                textBox46.Text = " ";
                numericUpDown20.Value = 0;
                numericUpDown20.Hide();
                numericUpDown20.Enabled = false;
                
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown19.Show();
            if (checkBox19.Checked)
            {
                numericUpDown19.Enabled = true;
                textBox45.Text = "เจ้าหญิงเขียว";
            }
            else
            {
                textBox45.Text = " ";
                numericUpDown19.Hide();
                numericUpDown19.Enabled = false;
                numericUpDown19.Value = 0;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown18.Show();
            if (checkBox18.Checked)
            {
                numericUpDown18.Enabled = true;
                textBox44.Text = "เจ้าหญิงฟ้า";
            }
            else
            {
                textBox44.Text = " ";
                numericUpDown18.Hide();
                numericUpDown18.Enabled = false;
                numericUpDown18.Value = 0;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown17.Show();
            if (checkBox17.Checked)
            {
                numericUpDown17.Enabled = true;
                textBox43.Text = "เจ้าหญิงแดง";
            }
            else
            {
                textBox43.Text = " ";
                numericUpDown17.Hide();
                numericUpDown17.Enabled = false;
                numericUpDown17.Value = 0;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown16.Show();
            if (checkBox16.Checked)
            {
                numericUpDown16.Enabled = true;
                textBox42.Text = "เจ้าหญิงชมพู";
            }
            else
            {
                textBox42.Text = " ";
                numericUpDown16.Hide();
                numericUpDown16.Enabled = false;
                numericUpDown16.Value = 0;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown15.Show();
            if (checkBox15.Checked)
            {
                numericUpDown15.Enabled = true;
                textBox41.Text = "ที่ลากช้าง";
            }
            else
            {
                textBox41.Text = " ";
                numericUpDown15.Hide();
                numericUpDown15.Enabled = false;
                numericUpDown15.Value = 0;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown14.Show();
            if (checkBox14.Checked)
            {
                numericUpDown14.Enabled = true;
                textBox40.Text = "ที่ลากจระเข้";
            }
            else
            {
                textBox40.Text = " ";
                numericUpDown14.Hide();
                numericUpDown14.Enabled = false;
                numericUpDown14.Value = 0;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown13.Show();
            if (checkBox13.Checked)
            {
                numericUpDown13.Enabled = true;
                textBox39.Text = "ที่ลากไดโนเสาร์";
            }
            else
            {
                textBox39.Text = " ";
                numericUpDown13.Hide();
                numericUpDown13.Enabled = false;
                numericUpDown13.Value = 0;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown12.Show();
            if (checkBox12.Checked)
            {
                numericUpDown12.Enabled = true;
                textBox38.Text = "ที่ลากเป็ด";
            }
            else
            {
                textBox38.Text = " ";
                numericUpDown12.Hide();
                numericUpDown12.Enabled = false;
                numericUpDown12.Value = 0;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown11.Show();
            if (checkBox11.Checked)
            {
                numericUpDown11.Enabled = true;
                textBox37.Text = "ที่ลากเม่น";
            }
            else
            {
                textBox37.Text = " ";
                numericUpDown11.Hide();
                numericUpDown11.Enabled = false;
                numericUpDown11.Value = 0;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown10.Show();
            if (checkBox10.Checked)
            {
                numericUpDown10.Enabled = true;
                textBox36.Text = "ไพ่";
            }
            else
            {
                textBox36.Text = " ";
                numericUpDown10.Hide();
                numericUpDown10.Enabled = false;
                numericUpDown10.Value = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown9.Show();
            if (checkBox9.Checked)
            {
                numericUpDown9.Enabled = true;
                textBox35.Text = "รูบิค";
            }
            else
            {
                textBox35.Text = " ";
                numericUpDown9.Hide();
                numericUpDown9.Enabled = false;
                numericUpDown9.Value = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown8.Show();
            if (checkBox8.Checked)
            {
                numericUpDown8.Enabled = true;
                textBox34.Text = "จิ๊กซอว์";
            }
            else
            {
                textBox34.Text = " ";
                numericUpDown8.Hide();
                numericUpDown8.Enabled = false;
                numericUpDown8.Value = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown7.Show();
            if (checkBox7.Checked)
            {
                numericUpDown7.Enabled = true;
                textBox33.Text = "จิ๊กซอว์ประกอบ";
            }
            else
            {
                textBox33.Text = " ";
                numericUpDown7.Hide();
                numericUpDown7.Enabled = false;
                numericUpDown7.Value = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown6.Show();
            if (checkBox6.Checked)
            {
                numericUpDown6.Enabled = true;
                textBox32.Text = "คอมสำหรับเด็ก";
            }
            else
            {
                textBox32.Text = " ";
                numericUpDown6.Hide();
                numericUpDown6.Enabled = false;
                numericUpDown6.Value = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown5.Show();
            if (checkBox5.Checked)
            {
                numericUpDown5.Enabled = true;
                textBox31.Text = "รถบังคับสีเหลือง";
            }
            else
            {
                textBox31.Text = " ";
                numericUpDown5.Hide();
                numericUpDown5.Enabled = false;
                numericUpDown5.Value = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Show();
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
                textBox30.Text = "รถบังคับสีส้ม";
            }
            else
            {
                textBox30.Text = " ";
                numericUpDown4.Hide();
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Show();
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
                textBox29.Text = "รถบังคับสีขาว";
            }
            else
            {
                textBox29.Text = " ";
                numericUpDown3.Hide();
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Show();
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
                textBox28.Text = "รถบังคับสีฟ้า";
            }
            else
            {
                textBox28.Text = " ";
                numericUpDown2.Hide();
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Show();
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
                textBox27.Text = "รถบังคับสีแดง";
            }
            else
            {
                textBox27.Text = " ";
                numericUpDown1.Hide();
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
            a7 = 0;
            a8 = 0;
            a9 = 0;
            a10 = 0;
            a11 = 0;
            a12 = 0;
            a13 = 0;
            a14 = 0;
            a15 = 0;
            a16 = 0;
            a17 = 0;
            a18 = 0;
            a19 = 0;
            a20 = 0;
            a21 = 0;
            a22 = 0;
            a23 = 0;
            a24 = 0;
            a25 = 0;

            textBox1.Text = numericUpDown1.Value.ToString();
            textBox2.Text = numericUpDown2.Value.ToString();
            textBox3.Text = numericUpDown3.Value.ToString();
            textBox4.Text = numericUpDown4.Value.ToString();
            textBox5.Text = numericUpDown5.Value.ToString();
            textBox6.Text = numericUpDown6.Value.ToString();
            textBox7.Text = numericUpDown7.Value.ToString();
            textBox8.Text = numericUpDown8.Value.ToString();
            textBox9.Text = numericUpDown9.Value.ToString();
            textBox10.Text = numericUpDown10.Value.ToString();
            textBox11.Text = numericUpDown11.Value.ToString();
            textBox12.Text = numericUpDown12.Value.ToString();
            textBox13.Text = numericUpDown13.Value.ToString();
            textBox14.Text = numericUpDown14.Value.ToString();
            textBox15.Text = numericUpDown15.Value.ToString();
            textBox16.Text = numericUpDown16.Value.ToString();
            textBox17.Text = numericUpDown17.Value.ToString();
            textBox18.Text = numericUpDown18.Value.ToString();
            textBox19.Text = numericUpDown19.Value.ToString();
            textBox20.Text = numericUpDown20.Value.ToString();
            textBox21.Text = numericUpDown21.Value.ToString();
            textBox22.Text = numericUpDown22.Value.ToString();
            textBox23.Text = numericUpDown23.Value.ToString();
            textBox24.Text = numericUpDown24.Value.ToString();
            textBox25.Text = numericUpDown25.Value.ToString();

            
            if (checkBox1.Checked)
            {
                b1 = double.Parse(textBox1.Text);
                a1 = 1500;
                num1 = b1 * a1;
            }

            if (checkBox2.Checked)
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 700;
                num2 = b2 * a2;
            }

            if (checkBox3.Checked)
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 500;
                num3 = b3 * a3;
            }

            if (checkBox4.Checked)
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 1000;
                num4 = b4 * a4;
            }

            if (checkBox5.Checked)
            {
                b5 = double.Parse(textBox5.Text);
                a5 = 500;
                num5 = b5 * a5;
            }

            if (checkBox6.Checked)
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 300;
                num6 = b6 * a6;
            }

            if (checkBox7.Checked)
            {
                b7 = double.Parse(textBox7.Text);
                a7 = 200;
                num7 = b7 * a7;
            }

            if (checkBox8.Checked)
            {
                b8 = double.Parse(textBox8.Text);
                a8 = 100;
                num8 = b8 * a8;
            }

            if (checkBox9.Checked)
            {
                b9 = double.Parse(textBox9.Text);
                a9 = 50;
                num9 = b9 * a9;
            }

            if (checkBox10.Checked)
            {
                b10 = double.Parse(textBox10.Text);
                a10 = 100;
                num10 = b10 * a10;
            }

            if (checkBox11.Checked)
            {
                b11 = double.Parse(textBox11.Text);
                a11 = 20;
                num11 = b11 * a11;
            }

            if (checkBox12.Checked)
            {
                b12 = double.Parse(textBox12.Text);
                a12 = 20;
                num12 = b12 * a12;
            }

            if (checkBox13.Checked)
            {
                b13 = double.Parse(textBox13.Text);
                a13 = 20;
                num13 = b13 * a13;
            }

            if (checkBox14.Checked)
            {
                b14 = double.Parse(textBox14.Text);
                a14 = 20;
                num14 = b14 * a14;
            }

            if (checkBox15.Checked)
            {
                b15 = double.Parse(textBox15.Text);
                a15 = 20;
                num15 = b15 * a15;
            }

            if (checkBox16.Checked)
            {
                b16 = double.Parse(textBox16.Text);
                a16 = 150;
                num16 = b16 * a16;
            }

            if (checkBox17.Checked)
            {
                b17 = double.Parse(textBox17.Text);
                a17 = 200;
                num17 = b17 * a17;
            }

            if (checkBox18.Checked)
            {
                b18 = double.Parse(textBox18.Text);
                a18 = 200;
                num18 = b18 * a18;
            }

            if (checkBox19.Checked)
            {
                b19 = double.Parse(textBox19.Text);
                a19 = 200;
                num19 = b19 * a19;
            }

            if (checkBox20.Checked)
            {
                b20 = double.Parse(textBox20.Text);
                a20 = 150;
                num20 = b20 * a20;
            }

            if (checkBox21.Checked)
            {
                b21 = double.Parse(textBox21.Text);
                a21 = 200;
                num21 = b21 * a21;
            }

            if (checkBox22.Checked)
            {
                b22 = double.Parse(textBox22.Text);
                a22 = 100;
                num22 = b22 * a22;
            }

            if (checkBox23.Checked)
            {
                b23 = double.Parse(textBox23.Text);
                a23 = 150;
                num23 = b23 * a23;
            }

            if (checkBox24.Checked)
            {
                b24 = double.Parse(textBox24.Text);
                a24 = 200;
                num24 = b24 * a24;
            }

            if (checkBox25.Checked)
            {
                b25 = double.Parse(textBox25.Text);
                a25 = 100;
                num25 = b25 * a25;
            }

            alltotal = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12 + num13 + num14 + num15 + num16 + num17 + num18 + num19 + num20 + num21 + num22 + num23 + num24 + num25;
            textBox26.Text = alltotal.ToString();


            string sql = "SELECT * FROM `stock`";
            MySqlConnection conn_ = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
            MySqlCommand cmd = new MySqlCommand(sql, conn_);
            conn_.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            string sql_;
            MySqlConnection con;
            MySqlCommand cmd_;
            int x;
            
            while(reader.Read())
            {
                if (reader.GetString("toy")=="รถบังคับสีแดง")
                {
                    if (reader.GetInt32("amont") - b1 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b1);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b1 = 0; //รีเซ็ตค่าที่เลือกเข้ามาจาก numalic updown
                    }
                    else
                    {
                        MessageBox.Show("รถบังคับสีแดงหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                    
                }

                else if (reader.GetString("toy") == "รถบังคับสีฟ้า")
                {
                    if (reader.GetInt32("amont") - b2 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b2);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b2 = 0;
                    }
                    else
                    {
                        MessageBox.Show("รถบังคับสีฟ้าหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "รถบังคับสีขาว")
                {
                    if (reader.GetInt32("amont") - b3 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b3);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b3 = 0;
                    }
                    else
                    {
                        MessageBox.Show("รถบังคับสีขาวหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "รถบังคับสีส้ม")
                {
                    if (reader.GetInt32("amont") - b4 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b4);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b4 = 0;
                    }
                    else
                    {
                        MessageBox.Show("รถบังคับสีส้มหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "รถบังคับสีเหลือง")
                {
                    if (reader.GetInt32("amont") - b5 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b5);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b5 = 0;
                    }
                    else
                    {
                        MessageBox.Show("รถบังคับสีเหลืองหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "คอมสำหรับเด็ก")
                {
                    if (reader.GetInt32("amont") - b6 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b6);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b6 = 0;
                    }
                    else
                    {
                        MessageBox.Show("คอมสำหรับเด็กหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "จิ๊กซอว์ประกอบ")
                {
                    if (reader.GetInt32("amont") - b7 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b7);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b7 = 0;
                    }
                    else
                    {
                        MessageBox.Show("จิ๊กซอว์ประกอบหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "จิ๊กซอว์")
                {
                    if (reader.GetInt32("amont") - b8 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b8);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b8 = 0;
                    }
                    else
                    {
                        MessageBox.Show("จิ๊กซอว์หมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "รูบิค")
                {
                    if (reader.GetInt32("amont") - b9 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b9);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b9 = 0;
                    }
                    else
                    {
                        MessageBox.Show("รูบิคหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ไพ่")
                {
                    if (reader.GetInt32("amont") - b10 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b10);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b10 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ไพ่หมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ที่ลากเม่น")
                {
                    if (reader.GetInt32("amont") - b11 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b11);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b11 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ที่ลากเม่นหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ที่ลากเป็ด")
                {
                    if (reader.GetInt32("amont") - b12 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b12);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b12 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ที่ลากเป็ดหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ที่ลากไดโนเสาร์")
                {
                    if (reader.GetInt32("amont") - b13 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b13);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b13 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ที่ลากไดโนเสาร์หมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ที่ลากจระเข้")
                {
                    if (reader.GetInt32("amont") - b14 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b14);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b14 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ที่ลากจระเข้หมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ที่ลากช้าง")
                {
                    if (reader.GetInt32("amont") - b15 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b15);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b15 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ที่ลากช้างหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เจ้าหญิงชมพู")
                {
                    if (reader.GetInt32("amont") - b16 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b16);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b16 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เจ้าหญิงชมพูหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เจ้าหญิงแดง")
                {
                    if (reader.GetInt32("amont") - b17 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b17);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b17 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เจ้าหญิงแดงหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เจ้าหญิงฟ้า")
                {
                    if (reader.GetInt32("amont") - b18 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b18);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b18 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เจ้าหญิงฟ้าหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เจ้าหญิงเขียว")
                {
                    if (reader.GetInt32("amont") - b19 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b19);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b19 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เจ้าหญิงเขียวหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เจ้าหญิงม่วง")
                {
                    if (reader.GetInt32("amont") - b20 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b20);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b20 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เจ้าหญิงม่วงหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ทำความสะอาดบ้าน")
                {
                    if (reader.GetInt32("amont") - b21 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b21);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b21 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ทำความสะอาดบ้านหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ห้องครัว")
                {
                    if (reader.GetInt32("amont") - b22 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b22);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b22 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ห้องครัวหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ทอดไข่")
                {
                    if (reader.GetInt32("amont") - b23 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b23);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b23 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ทอดไข่หมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "ทำอาหาร")
                {
                    if (reader.GetInt32("amont") - b24 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b24);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b24 = 0;
                    }
                    else
                    {
                        MessageBox.Show("ทำอาหารหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }
                else if (reader.GetString("toy") == "เตาแก๊ส")
                {
                    if (reader.GetInt32("amont") - b25 >= 0)
                    {
                        x = reader.GetInt32("amont") - Convert.ToInt32(b25);
                        sql_ = $"UPDATE stock SET amont = '{x}' WHERE toy='{reader.GetString("toy")} '";
                        con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
                        cmd_ = new MySqlCommand(sql_, con);
                        con.Open();
                        int rows1 = cmd_.ExecuteNonQuery();
                        con.Close();
                        b25 = 0;
                    }
                    else
                    {
                        MessageBox.Show("เตาแก๊สหมด");
                        if (reader.GetInt32("amont") == 0)
                        {
                            this.Hide();
                            Form2 ss = new Form2();
                            ss.ShowDialog();
                        }
                    }
                }

            }

        }
    }
}
