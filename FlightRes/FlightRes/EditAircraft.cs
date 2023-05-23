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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightRes
{
    public partial class EditAircraft : Form
    {
        public EditAircraft()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from AIRCRAFT where ID = '" + textBox3.Text + "'", con);
            SqlDataReader data = getName.ExecuteReader();
            while (data.Read())
            {
                String ID = data.GetValue(0).ToString();
                String AEmail = data.GetValue(1).ToString();
                String TotalSeats = data.GetValue(2).ToString();

                textBox4.Text = AEmail;
                textBox2.Text = ID;
                textBox10.Text = TotalSeats;
            }
            data.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewAircraftAdmin();
            view.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);

                con.Open();

                //creating the sql insertion code 
                SqlCommand myCommand = new SqlCommand("UPDATE AIRCRAFT SET ID = @id, A_EMAIL = @aEmail,TOTAL_SEATS = @totalSeats where ID = '" + textBox3.Text + "'", con);
                myCommand.Parameters.AddWithValue("@id", textBox2.Text);
                myCommand.Parameters.AddWithValue("@aEmail", textBox4.Text);
                myCommand.Parameters.AddWithValue("@totalSeats", textBox10.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Aircraft Edited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
