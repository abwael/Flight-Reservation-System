using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FlightRes
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form start = new Start();
            start.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.ToString() == textBox6.Text.ToString())
            {
                if (radioButton1.Checked)
                {
                    SqlConnection con = new SqlConnection(Program.connectionString);
                    con.Open();
                    SqlCommand myCommand = new SqlCommand("insert into ADMIN (A_FNAME,A_EMAIL,A_LNAME,A_PASSWORD,A_PHONE_NUMBER) " +
                        "values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')", con);
                    myCommand.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.connectionString);
                    con.Open();
                    SqlCommand myCommand = new SqlCommand("insert into PASSENGER (P_FNAME,P_EMAIL,P_LNAME,P_PASSWORD,P_PHONE_NUMBER) " +
                        "values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')", con);
                    myCommand.ExecuteNonQuery();
                    con.Close();
                }
                goodNews.Text = "Signed up successfully ! You can login now";
                goodNews.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                MessageBox.Show("Password is not the same!");
            }
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form start = new Start();
            start.Show();
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
