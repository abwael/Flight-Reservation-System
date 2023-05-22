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
    public partial class EditFlight : Form
    {
        public EditFlight()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            SqlCommand getName = new SqlCommand("select * from FLIGHT where FLIGHT_NUMBER = '" + textBox3.Text + "'", con);
            SqlDataReader data = getName.ExecuteReader();
            while (data.Read())
            {
                String FNum = data.GetValue(0).ToString();
                String ANum = data.GetValue(1).ToString();
                String AEmail = data.GetValue(2).ToString();
                DateTime FlightDate = data.GetDateTime(3);
                DateTime ArrTime = data.GetDateTime(4);
                DateTime LauTime = data.GetDateTime(5);
                String Source = data.GetValue(6).ToString();
                String Destination = data.GetValue(7).ToString();
                String Seats = data.GetValue(8).ToString();

                textBox1.Text = FNum;
                textBox2.Text = ANum;
                textBox4.Text = AEmail;
                dateTimePicker1.Value = FlightDate;
                dateTimePicker3.Value = LauTime;
                dateTimePicker2.Value = ArrTime;
                textBox8.Text = Source;
                textBox7.Text = Destination;
                textBox10.Text = Seats;
            }
            data.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.connectionString);

                con.Open();

                //creating the sql insertion code 
                SqlCommand myCommand = new SqlCommand("UPDATE FLIGHT SET FLIGHT_NUMBER = @flightNumber, AIRCRAFT_ID = @aircraftId, A_EMAIL = @aEmail,FLIGHT_DATE = @flightDate, ARRIVAL_TIME = @arrivalTime, LAUNCHING_TIME = @launchingTime, SOURCE_PLACE = @sourcePlace,DESTINATION_PLACE = @destinationPlace, SEATS_AVAILABLE = @seatsAvailable where FLIGHT_NUMBER = '" + textBox3.Text + "'", con);
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
                MessageBox.Show("Flight Edited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form view = new ViewFlightsAdmin();
            view.Show();
            this.Hide();
        }
    }
}
