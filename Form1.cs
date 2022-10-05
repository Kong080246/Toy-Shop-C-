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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string globaluser;
        public static string globalpassword;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "adminkong" && password.Text == "0956582462")
            {
                MessageBox.Show("HI TO ADMIN");
                new Form6().Show();
                this.Hide();
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;");
                MySqlDataAdapter log = new MySqlDataAdapter("SELECT COUNT(*) FROM customer WHERE user='" + user.Text + "' AND password='" + password.Text + "'", con);
                DataTable data = new DataTable();
                log.Fill(data);
                if (data.Rows[0][0].ToString() == "1")
                {
                    globaluser = user.Text;
                    globalpassword = password.Text;
                    MessageBox.Show("Successfully of login");
                    this.Hide();
                    Form2 MForm = new Form2();
                    MForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid username or password");
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 MForm = new Form3();
            MForm.ShowDialog();
            this.Close();
        }
    }
}
