using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightRes
{
    public partial class editpassword : Form
    {
        public editpassword()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from ADMIN where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            if (data.Read())
            {
                String Email = data.GetValue(0).ToString();
                String oldpass = data.GetValue(3).ToString();
                data.Close();
                if (textBox1.Text == oldpass)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        SqlCommand updateEmail = new SqlCommand("UPDATE ADMIN SET A_PASSWORD = '" + textBox2.Text + "' WHERE A_EMAIL = '" + Email + "'", con);
                        updateEmail.ExecuteNonQuery();
                        MessageBox.Show("password Updated successfully");

                    }
                    else
                    {
                        MessageBox.Show("Invalid New password");

                    }
                }
                else
                {
                    MessageBox.Show("Old Password is Incorrect!");
                }

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form edit = new editProfile();
            edit.Show();
            this.Hide();
        }
    }
}
