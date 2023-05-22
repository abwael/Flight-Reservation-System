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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewFlightsAdmin();
            view.Show();
            this.Hide();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand myCommand = new SqlCommand("insert into FLIGHT (FLIGHT_NUMBER,AIRCRAFT_ID,A_EMAIL,FLIGHT_DATE,ARRIVAL_TIME,LAUNCHING_TIME,SOURCE_PLACE,DESTINATION_PLACE,SEATS_AVAILABLE) " +
                "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker3.Value + "','" + dateTimePicker2.Value + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox10.Text + "')", con);
            myCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Flight Added Successfully");
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);

                con.Open();

                //creating the sql insertion code 
                SqlCommand myCommand = new SqlCommand("insert into FLIGHT (FLIGHT_NUMBER,AIRCRAFT_ID,A_EMAIL,FLIGHT_DATE,ARRIVAL_TIME,LAUNCHING_TIME,SOURCE_PLACE,DESTINATION_PLACE,SEATS_AVAILABLE) " +
                    "values(@flightNumber, @aircraftId, @aEmail, @flightDate, @arrivalTime, @launchingTime, @sourcePlace, @destinationPlace, @seatsAvailable)", con);
                myCommand.Parameters.AddWithValue("@flightNumber", textBox1.Text);
                myCommand.Parameters.AddWithValue("@aircraftId", textBox2.Text);
                myCommand.Parameters.AddWithValue("@aEmail", textBox4.Text);
                myCommand.Parameters.AddWithValue("@flightDate", dateTimePicker1.Value);
                myCommand.Parameters.AddWithValue("@arrivalTime", dateTimePicker2.Value);
                myCommand.Parameters.AddWithValue("@launchingTime", dateTimePicker3.Value);
                myCommand.Parameters.AddWithValue("@sourcePlace", textBox8.Text);
                myCommand.Parameters.AddWithValue("@destinationPlace", textBox7.Text);
                myCommand.Parameters.AddWithValue("@seatsAvailable", textBox10.Text);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
