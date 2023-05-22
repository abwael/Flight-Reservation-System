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
    public partial class editProfilePassenger : Form
    {
        public editProfilePassenger()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from PASSENGER where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            while (data.Read())
            {
                String Email = data.GetValue(0).ToString();
                String Fname = data.GetValue(1).ToString();
                String Lname = data.GetValue(2).ToString();
                String phoneNum = data.GetValue(4).ToString();

                textBox1.Text = Fname;
                textBox2.Text = Lname;
                textBox3.Text = phoneNum;
                textBox4.Text = Email;
            }
            data.Close();
            con.Close();
        }

        private void editProfilePassenger_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new viewProfilePassenger();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select P_EMAIL from PASSENGER where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            String Email;
            if (data.Read())
            {
                Email = data.GetValue(0).ToString();
                data.Close();

                SqlCommand updateEmail = new SqlCommand("UPDATE PASSENGER SET P_EMAIL = '" + textBox4.Text + "' WHERE P_EMAIL = '" + Email + "'", con);
                updateEmail.ExecuteNonQuery();

                SqlCommand updateFname = new SqlCommand("UPDATE PASSENGER SET P_FNAME = '" + textBox1.Text + "' WHERE P_EMAIL = '" + Email + "'", con);
                updateFname.ExecuteNonQuery();

                SqlCommand updateLname = new SqlCommand("UPDATE PASSENGER SET P_LNAME = '" + textBox2.Text + "' WHERE P_EMAIL = '" + Email + "'", con);
                updateLname.ExecuteNonQuery();

                SqlCommand updatePhoneNum = new SqlCommand("UPDATE PASSENGER SET P_PHONE_NUMBER = '" + textBox3.Text + "' WHERE P_EMAIL = '" + Email + "'", con);
                updatePhoneNum.ExecuteNonQuery();

                MessageBox.Show("Data Updated Successfully");
            }

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
