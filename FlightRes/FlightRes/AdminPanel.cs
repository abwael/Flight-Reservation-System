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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select A_FNAME, A_LNAME from admin where status = 1", con);
            SqlDataReader data = getName.ExecuteReader();
            while (data.Read())
            {
                String Fname = data.GetValue(0).ToString();
                String Lname = data.GetValue(1).ToString();
                label1.Visible = true;
                label1.Text = Fname + " " + Lname;
            }
            data.Close();
            con.Close();
        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getEmail = new SqlCommand("select A_EMAIL from admin where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                SqlCommand updateStatus = new SqlCommand("UPDATE ADMIN SET STATUS = 0 WHERE A_EMAIL = '" + Email + "'", con);
                updateStatus.ExecuteNonQuery();
            }

            con.Close();
            Form start = new Start();
            start.Show();
            this.Hide();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form view_profile = new viewProfile();
            view_profile.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form flights = new ViewFlightsAdmin();
            flights.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form aircraft = new ViewAircraftAdmin();
            aircraft.Show();
            this.Hide();
        }
    }
}
