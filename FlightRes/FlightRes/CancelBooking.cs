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
    public partial class CancelBooking : Form
    {
        public CancelBooking()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            // get email
            String PEmail = "";
            SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                PEmail = Email;
            }
            SqlCommand myCommand = new SqlCommand("select Flight.Flight_Number, Flight.Flight_Date, FLIGHT.Source_PLACE, FLIGHT.DESTINATION_PLACE, Flight.Arrival_Time, FLIGHT.Launching_Time, BOOKING.SEA_SEAT_NUMBER as Seat_Number, SEAT.CLASS from Booking INNER JOIN Flight ON BOOKING.FLI_FLIGHT_NUMBER = FLIGHT.FLIGHT_NUMBER INNER JOIN SEAT ON FLIGHT.FLIGHT_NUMBER = SEAT.FLIGHT_NUMBER WHERE BOOKING.PAS_P_EMAIL = @Email AND BOOKING.SEA_SEAT_NUMBER = SEAT.SEAT_NUMBER", con);
            myCommand.Parameters.AddWithValue("@Email", PEmail);
            myCommand.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            // get email
            String PEmail = "";
            SqlCommand getEmail = new SqlCommand("select P_EMAIL from passenger where status = 1", con);
            SqlDataReader email = getEmail.ExecuteReader();
            if (email.Read())
            {
                String Email = email.GetValue(0).ToString();
                email.Close();
                PEmail = Email;
            }

            // get Available Seats
            int AvailableSeats = 0;
            SqlCommand getSeats = new SqlCommand("select SEATS_AVAILABLE from FLIGHT where FLIGHT_NUMBER = '" + textBox2.Text + "'", con);
            SqlDataReader seats = getSeats.ExecuteReader();
            if (seats.Read())
            {
                int Seats = Int32.Parse(seats.GetValue(0).ToString());
                seats.Close();
                AvailableSeats = Seats;
            }

            try
            {
                //Deleting Booking
                SqlCommand myCommand = new SqlCommand("delete from booking where SEA_SEAT_NUMBER = @Seat AND PAS_P_EMAIL = @Email and FLI_FLIGHT_NUMBER = @FlightNumber", con);
                myCommand.Parameters.AddWithValue("@Seat", textBox3.Text);
                myCommand.Parameters.AddWithValue("@Email", PEmail);
                myCommand.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
                int rowsAffected = myCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //Editing Seat
                    SqlCommand EditOldSeat = new SqlCommand("update SEAT set STATUS = 'available' where FLIGHT_NUMBER = @FlightNumber AND SEAT_NUMBER = @CurrentSeat", con);
                    EditOldSeat.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
                    EditOldSeat.Parameters.AddWithValue("@CurrentSeat", textBox3.Text);
                    EditOldSeat.ExecuteNonQuery();

                    //Editing Flight Available Seats
                    SqlCommand EditFlightAvailbale = new SqlCommand("update FLIGHT set SEATS_AVAILABLE = @seatsAvailable where FLIGHT_NUMBER = @FlightNumber", con);
                    EditFlightAvailbale.Parameters.AddWithValue("@seatsAvailable", (AvailableSeats + 1));
                    EditFlightAvailbale.Parameters.AddWithValue("@FlightNumber", textBox2.Text);
                    EditFlightAvailbale.ExecuteNonQuery();

                    MessageBox.Show("Booking Canceld");
                }
                else
                {
                    MessageBox.Show("Invaled Flight Number or Seat Number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form view = new ViewBookedFlights();
            view.Show();
            this.Hide();
        }
    }
}
