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

namespace FlightRes
{
    public partial class EditPassengerPass : Form
    {
        public EditPassengerPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from PASSENGER where status = 1", con);
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
                        SqlCommand updateEmail = new SqlCommand("UPDATE PASSENGER SET P_PASSWORD = '" + textBox2.Text + "' WHERE P_EMAIL = '" + Email + "'", con);
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
            Form Pback = new editProfilePassenger();
            Pback.Show();
            this.Hide();
        }
    }
}
