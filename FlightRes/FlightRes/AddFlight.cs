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
                generateSeats(con);
                con.Close();
                MessageBox.Show("Flight Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void generateSeats(SqlConnection con)
        {
            int seatsAvailable = Convert.ToInt32(textBox10.Text);
            for (int i = 1; i<=seatsAvailable; i++)
            {
                SqlCommand myCommand = new SqlCommand("insert into SEAT (SEAT_NUMBER,FLIGHT_NUMBER,STATUS,CLASS,PRICE) " +
                   "values(@seatnumber, @flightnumber, @status, @class, @price)", con);
                myCommand.Parameters.AddWithValue("@seatnumber", i);
                myCommand.Parameters.AddWithValue("@flightnumber", textBox1.Text);
                myCommand.Parameters.AddWithValue("@status", "available");
                if (i >= 1 && i <= (seatsAvailable * 0.2))
                {
                    myCommand.Parameters.AddWithValue("@class", "First Class");
                    myCommand.Parameters.AddWithValue("@price", 20000);
                }
                else if (i > (seatsAvailable * 0.2) && i <= (seatsAvailable * 0.6))
                {
                    myCommand.Parameters.AddWithValue("@class", "Business Class");
                    myCommand.Parameters.AddWithValue("@price", 10000);
                }
                else
                {
                    myCommand.Parameters.AddWithValue("@class", "Economy Class");
                    myCommand.Parameters.AddWithValue("@price", 6000);
                }
                myCommand.ExecuteNonQuery();
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
