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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            //Connection String สำหรับใช้เชื่อมต่อฐานข้อมูล โดยระบุชื่อ Host,Port,Username,Password และชื่อ database
            string connectionString = "host=localhost;user=root;password=;database=project";

            //สร้างตัวแปลชื่อ conn เพื่อใช้เก็บการเชื่อมต่อฐานข้อมูล โดยใส่ค่า conncetionstring เข้าไป
            MySqlConnection conn = new MySqlConnection(connectionString);

            //ส่งค่าการเชื่อมต่อฐานข้อมูลกลับไปยังที่ที่เรียกใช้งาน Method
            return conn;
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM customer";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();


        }
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("โปรดใส่ข้อมูลก่อนทำรายการ");
                return;
            }
            else if (textBox3.Text.Length != 0)
            {
                string sql = $"SELECT * FROM `customer` WHERE user = '{textBox1.Text}';";
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    MessageBox.Show("มีคนใช้งานอันนี้แล้วครับ");

                }
                else
                {
                    MySqlConnection con_ = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                    String sql_ = "INSERT INTO customer (name,address,tel,user,password) VALUES('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                    MySqlCommand cmd_ = new MySqlCommand(sql_, con_);

                    con_.Open();

                    int rows_ = cmd_.ExecuteNonQuery();

                    con_.Close();

                    if (rows_ > 0)
                    {
                        MessageBox.Show("Success");
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("กลับสู่หน้าแรก");
            this.Hide();
            Form1 MForm = new Form1();
            MForm.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showEquipment();
        }
    }
}
