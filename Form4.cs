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
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double ton, pricenet, allton;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            Hide();
            printPreviewDialog1.ShowDialog();
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
            String sql = "INSERT INTO history (lastuser,item,price,datena) VALUES('" + last.Text + "','" + bill.Text + "','" + textBox2.Text + "','" + System.DateTime.Now.ToString("dd/MM/yyyy ") + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            con.Close();

            if (rows > 0)
            {
                MessageBox.Show("Success");
            }

        }

        private void bill_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM customer WHERE user='" + Form1.globaluser + "' AND password='" + Form1.globalpassword + "'";
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                last.Text = reader.GetString(1);

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("[ TOY SHOP ]", new Font("Century Gothic", 26, FontStyle.Bold), Brushes.Black, new Point(120, 60));
            e.Graphics.DrawString("Date " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("Century Gothic", 14, FontStyle.Regular), Brushes.Black, new PointF(500, 150));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 180));
            e.Graphics.DrawString(" ชื่อผู้ซื้อ                                        รายการสินค้า  ", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(100, 220));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 260));

            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;");
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT lastuser,item,price FROM history"; 
            MySqlDataReader dr = cmd.ExecuteReader();
            int y_ = 0;

            e.Graphics.DrawString($"{last.Text} ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, (y_ + 300)));
            e.Graphics.DrawString($"{bill.Text} ", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(470, (y_ + 300)));

            conn.Close();
            
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 880));
            int y = 320;
            e.Graphics.DrawString("ราคารวม", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, (y + 600)));
            e.Graphics.DrawString($"{textBox2.Text} Bath", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(600, (y + 600)));
            e.Graphics.DrawString("------------------------------------------------------------------------------------", new Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, new Point(100, 950));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != "")
            {
                pricenet = double.Parse(textBox2.Text);
                ton = double.Parse(textBox1.Text);
                allton = ton - pricenet;
                if(allton >= 0)
                {
                    MessageBox.Show("เงินทอนของคุณ" + allton);
                    if (allton < 0)
                    {
                        MessageBox.Show("ต้องจ่ายเงินก่อน");
                    }
                    else
                    {
                        MessageBox.Show("จ่ายแล้วนะ");
                        button3.Show();
                    }
                }
                else
                {
                    MessageBox.Show("ต้องจ่ายเงินให้ครบจำนวน");
                }
            }
            else
            {
                MessageBox.Show("ต้องจ่ายเงินก่อน");
            }
        }
    }
}
