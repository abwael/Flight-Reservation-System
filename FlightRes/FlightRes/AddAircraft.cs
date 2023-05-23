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
    public partial class AddAircraft : Form
    {
        public AddAircraft()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);

                con.Open();

                //creating the sql insertion code 
                SqlCommand myCommand = new SqlCommand("insert into AIRCRAFT (ID,A_EMAIL,TOTAL_SEATS) values(@id,@aEmail,@totalSeats)", con);
                myCommand.Parameters.AddWithValue("@id", textBox2.Text);
                myCommand.Parameters.AddWithValue("@aEmail", textBox4.Text);
                myCommand.Parameters.AddWithValue("@totalSeats", textBox10.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Aircraft Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewAircraftAdmin();
            view.Show();
            this.Hide();
        }

        private void AddAircraft_Load(object sender, EventArgs e)
        {

        }
    }
}
