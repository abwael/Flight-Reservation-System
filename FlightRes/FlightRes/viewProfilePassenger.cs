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
    public partial class viewProfilePassenger : Form
    {
        public viewProfilePassenger()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form passenger = new PassengerPanel();
            passenger.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form edit = new editProfilePassenger();
            edit.Show();
            this.Hide();
        }

        private void viewProfilePassenger_Load(object sender, EventArgs e)
        {

        }
    }
}
